using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QuanLyKhachSan
{
    public partial class frmQLPhong : Form
    {
        private List<int> ListIdRoom = null;
        private List<RoomDTO> ListRoom = null;
        private BindingSource dataSource = new BindingSource();
        private string nameRoom;
        private int iD, idRoom;
        private string IsstatusRoom;
        int statusRoom = 1;
      
        public frmQLPhong()
        {
            InitializeComponent();
         
            ListRoom = new List<RoomDTO>();
            ListIdRoom = new List<int>();

        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {

            dtgvDanhsachPhongQLP.DataSource = dataSource;
            LoadRoom();
            AddBinding();
            LoadStatusRoom();
            LoadRoomType();
            LoadIdRoom();


        }

        private void LoadRoom()
        {


            ListRoom = (List<RoomDTO>)RoomBLL.Instance.readAll();
            dtgvDanhsachPhongQLP.AutoGenerateColumns = false;
            dataSource.DataSource = ListRoom;
            


        }
        private void InitPropertiesRoom()
        {
            string getIdByName = cbbLoaiPhongQLP.GetItemText(this.cbbLoaiPhongQLP.SelectedValue.ToString());
            iD = int.Parse(getIdByName);
            idRoom = Convert.ToInt32(cbbMaPhongQLP.GetItemText(this.cbbMaPhongQLP.SelectedItem.ToString()));
        }

        private void LoadIdRoom()
        {
            foreach (var items in ListRoom)
            {
                ListIdRoom.Add(items.Id);

            }
            cbbMaPhongQLP.DataSource = ListIdRoom;

        }
        private void LoadStatusRoom()
        {
            cbStatusRoom.DataSource = RoomBLL.Instance.LoadStatusRoom();
            cbStatusRoom.DisplayMember = "NameStatusRoom";
            cbStatusRoom.ValueMember = "IdStatusRoom";

        }
        private void LoadRoomType()
        {
            cbbLoaiPhongQLP.DataSource = RoomBLL.Instance.LoadRoomType();
            cbbLoaiPhongQLP.DisplayMember = "NameRoomType";
            cbbLoaiPhongQLP.ValueMember = "IdRoomType";
        }

        private void AddBinding()
        {
            
            txtSoNguoiToiDa.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Limitperson"));
            txtGiaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Price"));
            txtTenPhong.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "NameRoom"));
            cbbLoaiPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameRoomType"));
            cbStatusRoom.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameStatusRoom"));
            cbbMaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "ID"));
           
            


        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            int n;


            if (txtTimKiemRoom.Text == "")
            {
                dataSource.DataSource = ListRoom;
            }
            else
            {
                if (txtTimKiemRoom.Text.StartsWith("P") || txtTimKiemRoom.Text.StartsWith("p"))
                {
                    dataSource.DataSource = ListRoom.Find(p => p.NameRoom == txtTimKiemRoom.Text);
                }
                else
                {
                    bool isNumeric = int.TryParse(txtTimKiemRoom.Text, out n);
                    if (isNumeric)
                        dataSource.DataSource = ListRoom.Find(p => p.Id == n);
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                }

            }

        }
        private IEnumerable<RoomDTO> IsNameInvalid()
        {
            IEnumerable<RoomDTO> filtered = from RoomDTO i in ListRoom
                                            where i.NameRoom.CompareTo(txtTenPhong.Text) == 0
                                            select i;
            return filtered;
        }
        private void btnThemPhongQLP_Click(object sender, EventArgs e)
        {

            InitPropertiesRoom();
            int count = IsNameInvalid().Count();
            if (count == 0)
            {
                RoomDTO room = new RoomDTO(nameRoom: txtTenPhong.Text, idStatusRoom: statusRoom, idRoomType: iD, id: 0);
                RoomBLL.Instance.Insert(room);
                MessageBox.Show("Insert Successfully");
            }
            else
            {
                MessageBox.Show("Name Room Exist");
            }

        }

        private void dtgvDanhsachPhongQLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            nameRoom = dtgvDanhsachPhongQLP[1, e.RowIndex].Value.ToString();
            IsstatusRoom = dtgvDanhsachPhongQLP[5, e.RowIndex].Value.ToString();
        }

        private void btnCapnhatPhongQLP_Click(object sender, EventArgs e)
        {
          
            InitPropertiesRoom();
            int count = 0;
            count = IsNameInvalid().Count();
            if (txtTenPhong.Text.CompareTo(nameRoom) == 0  && IsstatusRoom.CompareTo("Trống")==0 || count == 0 && IsstatusRoom.CompareTo("Trống") == 0)
            {
                int idStatusRoom = Convert.ToInt32(cbStatusRoom.GetItemText(this.cbStatusRoom.SelectedValue.ToString()));
                RoomDTO room = new RoomDTO(nameRoom: txtTenPhong.Text, idStatusRoom: idStatusRoom, idRoomType: iD, id: idRoom);
                if (RoomBLL.Instance.UpdateById(idRoom, room))
                {
                    MessageBox.Show("Update Successfully");
                    LoadIdRoom();
                }

            }else if (IsstatusRoom.CompareTo("Trống") != 0)
            {
                MessageBox.Show("Phòng đã có người");
            }
            else
            {
                MessageBox.Show("Name Room Exist");
            }
        }

    }
}
