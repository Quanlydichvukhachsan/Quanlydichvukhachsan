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
    public partial class frmQLNV : Form
    {
        List<StaffDTO> listStaff = new List<StaffDTO>();
        public frmQLNV()
        {
            InitializeComponent();
            listStaff = (List<StaffDTO>)StaffBLL.Instance.readAll();
        }
        private BindingSource dataSource = new BindingSource();

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            dtgNhanVien.DataSource = dataSource;
            LoadStaff();
        }
        private void LoadStaff()
        {
            dataSource.DataSource = listStaff;
        }

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindNV();
        }
        private void FindNV()
        {

            if (txtbSearch.Text == "")
            {
                MessageBox.Show("Nhập thông tin cần tìm!");
            }
            else
            {

              var filter =   listStaff.Find(p => p.UserName.CompareTo(txtbSearch.Text) == 0);
                if(filter != null)
                {
                    txtbLogin.Text = filter.UserName;
                    txtCMND.Text = filter.IdCard.ToString();
                    txtDiachi.Text = filter.Address;
                    txtNameNV.Text = filter.DisplayName;
                    cbLoaiNV.Text = filter.Name;
                    txtSDT.Text = filter.PhoneNumber.ToString();
                    cbGioiTinh.Text = filter.Sex;
                }
                else
                {
                    MessageBox.Show("Không có nhân viên cần tìm!");
                }
                


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbLogin.Text = "";
            txtCMND.Text = "";
            txtDiachi.Text = "";
            txtNameNV.Text = "";
            cbLoaiNV.Text = "";
            txtSDT.Text = "";
            cbLoaiNV.Text = "";
            cbGioiTinh.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertNV frm = new InsertNV();
            frm.Show();
        }
    }
}
