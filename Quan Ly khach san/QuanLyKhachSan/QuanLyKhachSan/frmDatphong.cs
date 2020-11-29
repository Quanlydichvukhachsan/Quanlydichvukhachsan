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
        public frmDatphong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadBookRoomByDate()
        {
           dtgvBookRoom.DataSource= BookRoomBLL.Instance.ReadBookRoomByDate(DateTime.Parse("2018-06-24"));
        }

        private void frmDatphong_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNhanphong_Click(object sender, EventArgs e)
        {
            LoadBookRoomByDate();
        }
    }
}
