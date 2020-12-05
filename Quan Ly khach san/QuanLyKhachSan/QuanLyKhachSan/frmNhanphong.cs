using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Receive;
using DTO;
using BLL;
using BLL.Receive;
namespace QuanLyKhachSan
{
    public partial class frmNhanphong : Form
    {
        private List<BookRoomDTO> listBookRoom = new List<BookRoomDTO>();
        private BindingSource dataSource = new BindingSource();
        private List<RoomDTO> listRoom = new List<RoomDTO>();
        private List<ReceiveDTO> ListReceive = new List<ReceiveDTO>();
        private List<CustomerDTO> ListCustomer = new List<CustomerDTO>();
        private List<RoomType> ListRoomType = new List<RoomType>();
        private List<string> listnameRoom = new List<string>();
        private List<string> listnameRoomType = new List<string>();
        private int n;
        private int idRoom = 0;
        public frmNhanphong()
        {
            InitializeComponent();
        }

     
        private void frmNhanphong_Load(object sender, EventArgs e)
        {
            SetCombobox();
            dtpNgaynhan.Value = DateTime.Now;
            dtpGetNhanPhong.Value = DateTime.Now;
            dtgvNhanPhong.DataSource = dataSource;
            ListRoomType = (List<RoomType>)RoomBLL.Instance.LoadRoomType();
            ListReceive = ReceiveBLL.Instance.ReadAllReceiveRoom(dtpGetNhanPhong.Value);
            LoadReceiveByDate();
            LoadBookRoom();
            LoadRoom();
            LoadCustomer();
          
        }
        private void SetCombobox()
        {
            cbLoaiPhong.DataSource = null;
            cbPhong.DataSource = null;
        }

        private void LoadRoom()
        {
            listRoom = (List<RoomDTO>)RoomBLL.Instance.readAll();
        }
       private void LoadRoomType()
        {
            cbLoaiPhong.DataSource = ListRoomType;
            cbLoaiPhong.DisplayMember = "NameRoomType";
            cbLoaiPhong.ValueMember = "NameRoomType";
        }

        private void LoadCustomer()
        {
            ListCustomer = (List<CustomerDTO>)CustomersBLL.Instance.readAll();
        }
        private void LoadReceiveByDate()
        {
         
            dataSource.DataSource = ListReceive;
        }

        private void findIdBookRoom()
        {
            if(txtMadatphong.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }
            else
            {
                
                bool checkIdRoom = int.TryParse(txtMadatphong.Text, out n);
                if (checkIdRoom)
                {
                   var bookRoom = listBookRoom.Where(p => p.ID_ == n).ToList();
                       if(bookRoom.Count > 0)
                    {
                        var customer = ListCustomer.Find(p => p.ID_ == bookRoom[0].IDCustomer_);
                        if(customer != null)
                        {
                            txtCMND.Text = customer.IDCard_;
                            txtHovaten.Text = customer.Name_;
                            dtpNgaynhan.Value = bookRoom[0].DateCheckIn_;
                            dtpNgaytra.Value = bookRoom[0].DateCheckOut_;
                            dataSource.DataSource = bookRoom;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã đặt phòng!");
                    }
                }
                else
                {
                    MessageBox.Show("Không được nhập chữ");
                }
            }
        }
        private void LoadBookRoom()
        {
            listBookRoom = (List<BookRoomDTO>)BookRoomBLL.Instance.readAll();
        }

   
    
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            findIdBookRoom();
            
        }

        private void cbLoaiPhong_Click(object sender, EventArgs e)
        {
            LoadRoomType();
        }

        private void cbLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            cbPhong.Items.Clear();
            string nameRoomType = cbLoaiPhong.Text;

            var filter = from RoomDTO room in listRoom
                         where room.IdStatusRoom == 1 && room.NameRoomType.CompareTo(nameRoomType)==0
                         select room;
            txtTenloaiphong.Text = nameRoomType;
            foreach (RoomDTO items in filter)
            {
                cbPhong.Items.Add(items.NameRoom);
                cbPhong.Text = items.NameRoom;
            }
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = listRoom.Find(p => p.NameRoom.CompareTo(cbPhong.Text) == 0);
            txtGia.Text = filter.Price.ToString();
            txtTenphong.Text = cbPhong.Text;
            txtSonguoitoida.Text = filter.LimitPerson.ToString();
            idRoom = filter.Id;
        }

        private void dtpGetNhanPhong_ValueChanged(object sender, EventArgs e)
        {
            ListReceive = ReceiveBLL.Instance.ReadAllReceiveRoom(dtpGetNhanPhong.Value);
            dataSource.DataSource = ListReceive;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetCombobox();
            txtMadatphong.Text = "";
            txtCMND.Text = "";
            txtGia.Text = "";
            txtHovaten.Text = "";
            txtSonguoitoida.Text = "";
            txtTenphong.Text = "";
        }

        private void btnNhanphong_Click(object sender, EventArgs e)
        {
            if (txtMadatphong.Text == "")
            {
                MessageBox.Show("Tìm Thông tin đặt phòng trước khi đặt(nhập Id đặt phòng)");
            }
            else
            {
                if(idRoom == 0)
                {
                    MessageBox.Show("Nhập tên phòng cần nhận");
                }
                else
                {
                    ReceiveRoomDTO receiveRoom = new ReceiveRoomDTO { IdBookRoom = n, IdRoom = idRoom };
                    ReceiveBLL.Instance.Insert(receiveRoom);
                    MessageBox.Show("Nhập Phòng thành công");
                    
                }
                
            }
          
        }
    }
}
