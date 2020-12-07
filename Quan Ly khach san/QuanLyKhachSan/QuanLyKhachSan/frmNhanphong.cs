using BLL;
using BLL.Receive;
using DTO;
using DTO.Receive;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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
        private ReceiveDTO receiveRoom = null;
        private string idReceive = "",nameCustomer="",Cmnd ="",nameRoom="",dateIn="",dateOut="";
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
                            LoadRoomType();
                           var filter =  ListRoomType.Where(p=>p.IdRoomType ==bookRoom[0].IDRoomType_).ToList();
                            if (filter.Count() > 0) cbLoaiPhong.Text = filter[0].NameRoomType;
                            dtpNgaynhan.Value = bookRoom[0].DateCheckIn_;
                            dtpNgaytra.Value = bookRoom[0].DateCheckOut_;
                           
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
            Reset();
        }
        private void Reset()
        {
            SetCombobox();
            txtMadatphong.Text = "";
            txtCMND.Text = "";
            txtGia.Text = "";
            txtHovaten.Text = "";
            txtSonguoitoida.Text = "";
            txtTenphong.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    var getRoom = listRoom.Find(p => p.Id == idRoom);

                    RoomDTO room = new RoomDTO(getRoom.NameRoom, 2, getRoom.IdRoomType, getRoom.Id);
                    RoomBLL.Instance.UpdateById(idRoom, room);
                    LoadRoom();
                    Reset();
                    MessageBox.Show("Nhập Phòng thành công");

                    
                }
                
            }
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(idReceive == "")
            {
                MessageBox.Show("Chọn lại  phòng cần hủy!");
            }
            else
            {
                ReceiveBLL.Instance.DeleteById(idReceive);
                MessageBox.Show("Hủy phòng thành công!");
                ListReceive = ReceiveBLL.Instance.ReadAllReceiveRoom(dtpGetNhanPhong.Value);
                dataSource.DataSource = ListReceive;
            }
        }

      

        private void dtgvNhanPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idReceive = dtgvNhanPhong[0, e.RowIndex].FormattedValue.ToString();
            nameCustomer = dtgvNhanPhong[1, e.RowIndex].FormattedValue.ToString();
             Cmnd = dtgvNhanPhong[2, e.RowIndex].FormattedValue.ToString();
             nameRoom = dtgvNhanPhong[3, e.RowIndex].FormattedValue.ToString();
             dateIn = dtgvNhanPhong[4, e.RowIndex].FormattedValue.ToString();
             dateOut = dtgvNhanPhong[5, e.RowIndex].FormattedValue.ToString();
           
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(idReceive=="" ||nameCustomer ==""|| Cmnd ==""|| nameRoom =="" || dateIn =="" || dateOut == "")
            {
                MessageBox.Show("Chọn lại phòng cần xem!");
            }
            else
            {
                receiveRoom = new ReceiveDTO(Convert.ToInt32(idReceive), nameCustomer, Cmnd, nameRoom, DateTime.Parse(dateIn), DateTime.Parse(dateOut));
                if (dtgvNhanPhong.Rows.Count > 1 && receiveRoom != null)
                {
                    frmChitietnhanhphong frm = new frmChitietnhanhphong(receiveRoom);
                    frm.EventUpdateHandler += Frm_EventUpdateHandler;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Không có phòng cần xem!");
                }
            }
          
         
        }

        private void Frm_EventUpdateHandler(object sender, frmChitietnhanhphong.UpdateEventArgs args)
        {
            LoadRoom();
        }
    }
}
