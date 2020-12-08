using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmDatphong : Form
    {
        private int idRoom = 0, idCustomer = 0;
        private int idCustomers;
        private DateTime dateIn;
        private DateTime dateOut;

        public List<RoomType> roomTypes = new List<RoomType>();
        private BindingSource bindingSource = new BindingSource();
        private List<BookRoomByDateDTO> ListBookByDateRoom = null;
        private List<CustomerDTO> listCustomers = new List<CustomerDTO>();
        private List<BookRoomDTO> listBookRoom = new List<BookRoomDTO>();

        public frmDatphong()
        {
            InitializeComponent();
            ListBookByDateRoom = new List<BookRoomByDateDTO>();
            roomTypes = (List<RoomType>)RoomBLL.Instance.LoadRoomType();
            dtpNgayDat.Value = DateTime.Now;
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
            listBookRoom = (List<BookRoomDTO>)BookRoomBLL.Instance.readAll();
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
            else if (txtHovaten.Text == "" && txtHovaten.Text.Length != 10 || mtbInsertIdCard.Text == "" && mtbInsertIdCard.Text.Length != 9 ||
               mtbSDT.Text == "" && mtbSDT.Text.Length != 10 || txtDiachi.Text == "")
            {
                MessageBox.Show("Kiểm tra lại thông tin khách hàng", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                txtsodem.Text = numNight.ToString();
                BookRoomDTO bookRoom = new BookRoomDTO(idCustomers, Convert.ToInt32(txtMaphong.Text), dateTime, dtpNgayNhan.Value, dtpNgaytra.Value);
                BookRoomBLL.Instance.InsertBookRoom(bookRoom, dtpNgayDat.Value);
                MessageBox.Show("Đặt phòng thành công");
                LoadDgvBookRoom(dateTime);
            }
        }

        public void LoadCustomers()
        {
            listCustomers = (List<CustomerDTO>)CustomerBLL.Instance.readAll();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbSearchIdCard.Text == "")
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
                    if (filter.Count() >= 0)
                    {
                        idCustomers = filter.ToList()[0].ID_;
                        txtHovaten.Text = filter.ToList()[0].Name_;
                        mtbInsertIdCard.Text = filter.ToList()[0].IDCard_;
                        txtLoaiKhachHang.Text = filter.ToList()[0].NameCustomerType;
                        mtbSDT.Text = filter.ToList()[0].PhoneNumber_.ToString();
                        dtpNgaysinh.Value = filter.ToList()[0].DateOfBirth_;
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

        private BookRoomDTO bookRoom = null;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (idRoom == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã đặt phòng!");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc hủy phòng!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (BookRoomBLL.Instance.CancelBookRoom(idRoom))
                    {
                        MessageBox.Show("Hủy phòng thành công !");
                        listBookRoom = (List<BookRoomDTO>)BookRoomBLL.Instance.readAll();
                        dtpNgayDat.Value = DateTime.Now;
                        LoadDgvBookRoom(dtpNgayDat.Value);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công !");
                    }
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            ShowBookRoom frm = new ShowBookRoom(listBookRoom);
            frm.EventUpdateHandler += Frm_EventUpdateHandler;
            frm.Show();
        }

        private void Frm_EventUpdateHandler(object sender, ShowBookRoom.UpdateEventArgs args)
        {
            dtpNgayDat.Value = args.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idRoom == 0 || idCustomer == 0)
            {
                MessageBox.Show("Chọn lại phòng cần xem!");
            }
            else
            {
                frmChitietdatphong chitiet = new frmChitietdatphong(idRoom, idCustomer, dateIn, dateOut);
                chitiet.EventUpdateHandler += Chitiet_EventUpdateHandler;
                chitiet.Show();
            }
        }

        private void Chitiet_EventUpdateHandler(object sender, frmChitietdatphong.UpdateEventArgs args)
        {
            LoadCustomers(); 
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (dtgvBookRoom.Rows.Count > 1)
            {
                bindingSource.DataSource = ListBookByDateRoom.OrderBy(p => p.Name_);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void btnChuyendennhanphong_Click(object sender, EventArgs e)
        {
            frmNhanphong frm = new frmNhanphong();
            frm.Show();
        }

        private void dtgvBookRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRoom = int.Parse(dtgvBookRoom[0, e.RowIndex].FormattedValue.ToString());
            string NameCustomer = dtgvBookRoom[1, e.RowIndex].FormattedValue.ToString();

            var filter = listCustomers.Find(c => c.Name_.CompareTo(NameCustomer) == 0);
            idCustomer = filter.ID_;
            dateIn = DateTime.Parse(dtgvBookRoom[4, e.RowIndex].FormattedValue.ToString());
            dateOut = DateTime.Parse(dtgvBookRoom[5, e.RowIndex].FormattedValue.ToString());
        }
    }
}