using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;



namespace QuanLyKhachSan
{
    public partial class frmDatphong : Form
    {
        private int idRoom;
        private string NameCustomer, idCard;
        private DateTime ngayNhan, ngayTra;

        public List<RoomType> roomTypes = new List<RoomType>();
        private BindingSource bindingSource = new BindingSource();
        private List<BookRoomByDateDTO> ListBookByDateRoom = null;
        private List<CustomerDTO> listCustomers = new List<CustomerDTO>();
        private List<BookRoomDTO> listBookRoom = new List<BookRoomDTO>();
        int idCustomers;
        public frmDatphong()
        {
            InitializeComponent();
            ListBookByDateRoom = new List<BookRoomByDateDTO>();
            roomTypes = (List<RoomType>)RoomBLL.Instance.LoadRoomType();
        }

        public void LoadDgvBookRoom(DateTime date)
        {            
            dtgvBookRoom.Rows.Clear();

            ListBookByDateRoom = new List<BookRoomByDateDTO>(BookRoomBLL.Instance.ReadBookRoomByDate(date));
            bindingSource.DataSource = ListBookByDateRoom;
           
        }
        private void AddBinding()
        {
            txtMaphong.DataBindings.Add(new Binding("Text", cbLoaiphong.DataSource, "IdRoomType"));
            txtTenloaiphong.DataBindings.Add(new Binding("Text", cbLoaiphong.DataSource, "NameRoomType"));
            txtSonguoitoida.DataBindings.Add(new Binding("Text", cbLoaiphong.DataSource, "LimitPerson"));
            txtGia.DataBindings.Add(new Binding("Text", cbLoaiphong.DataSource, "Price"));
        }

        private void LoadComboTypeRoom()
        {
            cbLoaiphong.DataSource = RoomBLL.Instance.LoadRoomType();
            cbLoaiphong.DisplayMember = "NameRoomType";
        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
       
        public void DateDefault()
        {
            dtpNgayDat.Value = DateTime.Today.AddDays(0);
            dtpNgayNhan.Value = DateTime.Today.AddDays(0);
            dtpNgaytra.Value = DateTime.Today.AddDays(1);
            DateTime checkIn = dtpNgayNhan.Value;
            DateTime checkOut = dtpNgaytra.Value;
            TimeSpan result = checkOut - checkIn;
           
            txtsodem.Text = Convert.ToString(result.Days);
        }
        private void frmDatphong_Load(object sender, EventArgs e)
        {
            dtgvBookRoom.AutoGenerateColumns = false;
            dtgvBookRoom.DataSource = bindingSource;
            DateDefault();
            LoadDgvBookRoom(dtpNgayDat.Value);
            LoadComboTypeRoom();
            AddBinding();
            LoadCustomers();
        }

        private void dtpNgaynhan_ValueChanged(object sender, EventArgs e)
        {
            LoadDgvBookRoom(dtpNgayDat.Value);
        }

        private void btnNhanphong_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpNgayNhan.Value;
            DateTime checkOut = dtpNgaytra.Value;

            TimeSpan result = checkOut - checkIn;
            int numNight = result.Days;
           
            if (numNight <= 0 || checkOut <= checkIn || checkIn < DateTime.Today.AddDays(0))
            {
                MessageBox.Show("Kiểm tra lại thông ngày nhận hoặc ngày trả");
            }
            else
            {
                DateTime dateTime = dtpNgayDat.Value;
                txtsodem.Text = numNight.ToString();
                BookRoomDTO bookRoom = new BookRoomDTO(idCustomers, int.Parse(txtMaphong.Text), dtpNgayDat.Value, dtpNgayNhan.Value, dtpNgaytra.Value);
                BookRoomBLL.Instance.InsertBookRoom(bookRoom, dateTime);
                MessageBox.Show("Đặt phòng thành công");
                LoadDgvBookRoom(dtpNgayDat.Value);
                
            }

            


            //if (txtHovaten.Text == "" && txtHovaten.Text.Length != 10 || mtbInsertIdCard.Text == "" && mtbInsertIdCard.Text.Length != 9 ||
            //    mtbSDT.Text == "" && mtbSDT.Text.Length != 10 || txtDiachi.Text == "")
            //    MessageBox.Show("Kiểm tra lại thông tin khách hàng", "Cảnh báo", MessageBoxButtons.OK);
            //else
            //{
            //   // var fillterName = listCustomerType.FindAll(p => p.Name_.CompareTo(cbLoaikhachhang.Text) == 0);
            //   //int idCustomer = fillterName[0].ID_;
            //   // CustomerDTO customer = new CustomerDTO(mtbInsertIdCard.Text,idCustomer , txtHovaten.Text, dtpNgaysinh.Value, txtDiachi.Text,
            //   //     (mtbSDT.Text), cbGioitinh.Text, cbQuoctich.Text);

            //   // CustomerBLL.Instance.Insert(customer);
            //}                                      
            ////HandlerError.CheckLengthEqualTO(iDCard, 8, "CMN")
                  
        }

        public void LoadCustomers()
        {
            listCustomers = (List<CustomerDTO>)CustomerBLL.Instance.readAll();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbSearchIdCard.Text =="")
                {
                    MessageBox.Show("Chưa nhập CMND");
                }
                else
                {
                    string result = null;
                    var input = mtbSearchIdCard.Text;
                    var filter = from CustomerDTO customer in listCustomers
                                 where customer.IDCard_.CompareTo(input) == 0
                                 select customer;
                    if (filter.Count() ==1)
                    {
                        idCustomers = filter.ToList()[0].ID_;
                        txtHovaten.Text = filter.ToList()[0].Name_;
                        mtbInsertIdCard.Text = filter.ToList()[0].IDCard_;
                        txtLoaiKhachHang.Text = filter.ToList()[0].NameCustomerType;
                        mtbSDT.Text = filter.ToList()[0].PhoneNumber_;
                        dtpNgaysinh.Value =  filter.ToList()[0].DateOfBirth_ ;
                        txtDiachi.Text = filter.ToList()[0].Address_;
                        txtGioiTinh.Text = filter.ToList()[0].Sex1;
                        txtQuocTich.Text = filter.ToList()[0].Nationality_;            
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại chứng minh nhân dân");
                    }
                }    
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dtpNgayNhan_ValueChanged_1(object sender, EventArgs e)
        {
          
                txtsodem.Text = (dtpNgaytra.Value - dtpNgayNhan.Value).Days.ToString();
            
        
        }

        private void dtpNgaytra_ValueChanged(object sender, EventArgs e)
        {         
                txtsodem.Text = (dtpNgaytra.Value - dtpNgayNhan.Value).Days.ToString();          
        }
        BookRoomDTO bookRoom = null;
        private void button1_Click(object sender, EventArgs e)
        {
            frmChitietdatphong chitiet = new frmChitietdatphong(bookRoom);
            chitiet.Show();
        }

        private void dtgvBookRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

           idRoom= int.Parse(dtgvBookRoom[0, e.RowIndex].FormattedValue.ToString());
           NameCustomer =  dtgvBookRoom[1, e.RowIndex].FormattedValue.ToString();
            var filter = listCustomers.Find(c => c.Name_.CompareTo(NameCustomer) == 0);
           
           idCard= dtgvBookRoom[2, e.RowIndex].FormattedValue.ToString();
           ngayNhan= DateTime.Parse(dtgvBookRoom[3, e.RowIndex].FormattedValue.ToString());
           ngayTra=DateTime.Parse(dtgvBookRoom[4, e.RowIndex].FormattedValue.ToString());
            bookRoom = new BookRoomDTO { ID_ = idRoom,IDCustomer_=filter.ID_, DateCheckIn_ = ngayNhan, DateCheckOut_ = ngayTra };
        }
    }
}
