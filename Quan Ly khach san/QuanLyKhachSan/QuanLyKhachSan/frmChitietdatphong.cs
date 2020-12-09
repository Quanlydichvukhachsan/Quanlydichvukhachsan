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
    public partial class frmChitietdatphong : Form
    {
        
        frmDatphong datphong = new frmDatphong();
        public List<RoomType> roomTypes = new List<RoomType>();
        public List<BookRoomDTO> listBookRoom = new List<BookRoomDTO>();
        public List<CustomerDTO> listCustomer = new List<CustomerDTO>();
        private List<string> gioiTinh = new List<string>() { "Nam", "Nữ" };
        private List<string> Quoctich = new List<string>() { "Lào", "Mỹ", "Châu phi", "Ấn Độ", "Hoa kỳ", "Mỹ Đen", "Việt Nam", "Trung Quốc", "Nhật Bản", "Singapore" };
        private List<CustomerTypeDTO> ListcustomerTypes = new List<CustomerTypeDTO>();
        public frmChitietdatphong(int idRoom ,int idCustomer,DateTime dateIn ,DateTime dateOut)
        {

            InitializeComponent();
            IdRoom = idRoom;
            IdCustomer = idCustomer;
            DateIn = dateIn;
            DateOut = dateOut;
            ListcustomerTypes = (List<CustomerTypeDTO>)CustomerBLL.Instance.LoadCustomerType();
            listBookRoom = (List<BookRoomDTO>)BookRoomBLL.Instance.readAll();
            roomTypes = (List<RoomType>)RoomBLL.Instance.LoadRoomType();
            listCustomer =(List<CustomerDTO>)CustomerBLL.Instance.readAll();
        }
        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;
        public class UpdateEventArgs : EventArgs
        {
            
        }

        public void Update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
           
            EventUpdateHandler.Invoke(this, args);
        }
        public int IdRoom { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }


        public BookRoomDTO BookRoom { get; set; }

        private void btnLuuthaydoi_Click(object sender, EventArgs e)
        {
            if(txtMadatphong.Text == ""||cbTenloaiphong.Text =="")
            {

                MessageBox.Show("Điền đủ thông tin!");
            }
            else
            {
                var filter = listBookRoom.Find(p => p.ID_ == Convert.ToInt32(txtMadatphong.Text));
                var filterIdRoomType = roomTypes.Find(p => p.NameRoomType.CompareTo(cbTenloaiphong.Text) == 0);
                filter.IDRoomType_ = filterIdRoomType.IdRoomType;
                filter.DateCheckIn_ = dtpNgaynhan.Value;
                filter.DateCheckOut_ = dtpNgaytra.Value;
                BookRoomBLL.Instance.UpdateById(Convert.ToInt32(txtMadatphong.Text), filter);
                listBookRoom = (List<BookRoomDTO>)BookRoomBLL.Instance.readAll();
                MessageBox.Show("Update thành công!");
            }
         

        }

        public void DateDefault()
        {
           
            dtpNgaynhan.Value = DateTime.Today.AddDays(0);
            dtpNgaytra.Value = DateTime.Today.AddDays(1);
            DateTime checkIn = dtpNgaynhan.Value;
            DateTime checkOut = dtpNgaytra.Value;
            TimeSpan result = checkOut - checkIn;

            txtSodem.Text = Convert.ToString(result.Days);
        }
        private void frmChitietdatphong_Load(object sender, EventArgs e)
        {
            cbTenloaiphong.DataSource = roomTypes;
            cbTenloaiphong.DisplayMember = "NameRoomType";
            txtMadatphong.Text = IdRoom.ToString();
            dtpNgaynhan.Value = DateIn;
            dtpNgaytra.Value = DateOut;
            DateDefault();
            cbGioitinh.DataSource = gioiTinh;
            cbQuoctich.DataSource = Quoctich;
            cbLoaiKH.DataSource = ListcustomerTypes;
            cbLoaiKH.DisplayMember = "Name_";
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            var filter = listCustomer.Find(c => c.ID_ == IdCustomer);
            txtHovaten.Text = filter.Name_;
            txtCMND.Text = filter.IDCard_;
            txtDiachi.Text = filter.Address_;
            cbLoaiKH.Text = filter.NameCustomerType;
            txtSDT.Text = filter.PhoneNumber_.ToString();
            dtpNgaysinh.Value = filter.DateOfBirth_;
            cbGioitinh.Text = filter.Sex1;
            cbQuoctich.Text = filter.Nationality_;
        }

        private void btnCapnhatthongtinKH_Click(object sender, EventArgs e)
        {
            if(txtCMND.Text =="" ||txtDiachi.Text ==""||txtHovaten.Text =="" ||txtSDT.Text == "")
            {
                MessageBox.Show("Điền đủ thông tin khách hàng!");
            }
            else
            {
                var filter = listCustomer.Find(p => p.ID_ == IdCustomer);
                int idCustomerType = ListcustomerTypes.Find(p => p.Name_.CompareTo(cbLoaiKH.Text) == 0).ID_;

                CustomerDTO customer = new CustomerDTO(IdCustomer, txtCMND.Text, idCustomerType, txtHovaten.Text, dtpNgaysinh.Value,
                     txtDiachi.Text, Convert.ToInt32(txtSDT.Text), cbGioitinh.Text, cbQuoctich.Text);
                CustomerBLL.Instance.Update(customer);
                MessageBox.Show("Update thành công!");
                listCustomer = (List<CustomerDTO>)CustomerBLL.Instance.readAll();
                Update();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }

