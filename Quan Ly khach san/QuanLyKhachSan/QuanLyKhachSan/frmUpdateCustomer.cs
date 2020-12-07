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
    public partial class frmUpdateCustomer : Form
    {
        public frmUpdateCustomer(string cmnd,List<CustomerDTO> listCustomer)
        {
            InitializeComponent();
            Cmnd = cmnd;
            ListCustomer = listCustomer;
        }
        public string Cmnd { get; set; }
        public List<CustomerDTO> ListCustomer { get; set; }
        private void btnluuthaydoi_Click(object sender, EventArgs e)
        {
            /*Chưa Update*/
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            FilterCustomer();
        }
        private void FilterCustomer()
        {
            var filter = ListCustomer.Find(p => p.IDCard_ == Cmnd);
            txtCMND.Text = filter.IDCard_;
            txtDiaChi.Text = filter.Address_;
            txtHoVaTen.Text = filter.Name_;
            cbQuocTich.Text = filter.Nationality_;
            txtSDT.Text = filter.PhoneNumber_.ToString();
            dtpNgaySinh.Value = filter.DateOfBirth_;
            
        }
    }
}
