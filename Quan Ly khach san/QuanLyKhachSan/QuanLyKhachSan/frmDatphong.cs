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
        private List<BookRoomByDateDTO> ListBookRoom = null;
        public frmDatphong()
        {
            InitializeComponent();
        }

        public void LoadDgvBookRoom(DateTime date)
        {

            int i = 0;
            dtgvBookRoom.Rows.Clear();
            ListBookRoom = new List<BookRoomByDateDTO>(BookRoomBLL.Instance.ReadBookRoomByDate(date));
            foreach (BookRoomByDateDTO lbroom in ListBookRoom)
            {
                dtgvBookRoom.Rows.Add();
                dtgvBookRoom.Rows[i].Cells[0].Value = lbroom.IDBookRom_;
                dtgvBookRoom.Rows[i].Cells[1].Value = lbroom.Name_;
                dtgvBookRoom.Rows[i].Cells[2].Value = lbroom.Cmnd_;
                dtgvBookRoom.Rows[i].Cells[3].Value = lbroom.RoomType_;
                dtgvBookRoom.Rows[i].Cells[4].Value = lbroom.DateCheckIn_;
                dtgvBookRoom.Rows[i].Cells[5].Value = lbroom.DateChockOut_;
                i++;
            }
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
       

        private void frmDatphong_Load(object sender, EventArgs e)
        {
            dtpNgaynhan.Value = DateTime.Today.AddDays(0); ;
            LoadDgvBookRoom(dtpNgaynhan.Value);
            LoadComboTypeRoom();
            AddBinding();
        }

        private void dtpNgaynhan_ValueChanged(object sender, EventArgs e)
        {
            LoadDgvBookRoom(dtpNgaynhan.Value);
        }
    }
}
