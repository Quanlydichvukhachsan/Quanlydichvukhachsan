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
        public frmChitietdatphong(BookRoomDTO bookRoom)
        {

            InitializeComponent();
            ListcustomerTypes = (List<CustomerTypeDTO>)BookRoomBLL.Instance.readAll();
            listBookRoom = (List<BookRoomDTO>)BookRoomBLL.Instance.readAll();
            roomTypes = (List<RoomType>)RoomBLL.Instance.LoadRoomType();
            BookRoom = bookRoom;
            listCustomer =(List<CustomerDTO>)CustomerBLL.Instance.readAll();
        }
        public BookRoomDTO BookRoom { get; set; }

        private void btnLuuthaydoi_Click(object sender, EventArgs e)
        {

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
            txtMadatphong.Text = BookRoom.ID_.ToString();
            dtpNgaynhan.Value = BookRoom.DateCheckIn_;
            dtpNgaytra.Value = BookRoom.DateCheckOut_;
            DateDefault();
            cbGioitinh.DataSource = gioiTinh;
            cbQuoctich.DataSource = Quoctich;
            cbLoaiKH.DataSource = ListcustomerTypes;
            cbLoaiKH.DisplayMember = "Name_";
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            var filter = listCustomer.Find(c => c.ID_ == BookRoom.IDCustomer_);
            txtHovaten.Text = filter.Name_;
            txtCMND.Text = filter.IDCard_;
            cbLoaiKH.Text = filter.NameCustomerType;
            txtSDT.Text = filter.PhoneNumber_;
            dtpNgaysinh.Value = filter.DateOfBirth_;
            cbGioitinh.Text = filter.Sex1;
            cbQuoctich.Text = filter.Nationality_;
        }
    }
}
