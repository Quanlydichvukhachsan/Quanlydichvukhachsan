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
    public partial class InsertNV : Form
    {
        public InsertNV()
        {
            InitializeComponent();
        }

        private void InsertNV_Load(object sender, EventArgs e)
        {
            
        }
        private void insert()
        {
            StaffDTO staff = new StaffDTO
            {
                UserName = txtbLogin.Text,
                DisplayName = txtNameNV.Text,
                Name = cbLoaiNV.Text,
                Pass = txtPass.Text,
                PhoneNumber = int.Parse(txtSDT.Text),
                Address = txtDiachi.Text,
                IdCard = int.Parse(txtCMND.Text),
                IdStaff = int.Parse(cbLoaiNV.Text)
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
