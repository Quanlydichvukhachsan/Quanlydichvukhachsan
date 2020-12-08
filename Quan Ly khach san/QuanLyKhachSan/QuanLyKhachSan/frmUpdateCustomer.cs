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
        public string Cmnd { get; set; }
        private int IdCustomer = 0;
        public List<CustomerDTO> ListCustomer { get; set; }
        private List<CustomerTypeDTO> ListcustomerTypes = new List<CustomerTypeDTO>();
        private List<string> Quoctich = new List<string>() { "Lào", "Mỹ", "Châu phi", "Ấn Độ", "Hoa kỳ", "Mỹ Đen", "Việt Nam", "Trung Quốc", "Nhật Bản", "Singapore" };

        public frmUpdateCustomer(string cmnd,List<CustomerDTO> listCustomer)
        {
            InitializeComponent();
            Cmnd = cmnd;
            ListCustomer = listCustomer;
            ListcustomerTypes = (List<CustomerTypeDTO>)CustomerBLL.Instance.LoadCustomerType();
        }
        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;

        public class UpdateEventArgs : EventArgs
        {
         
        }

        public void update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
           
            EventUpdateHandler.Invoke(this, args);
        }
        private void btnluuthaydoi_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == "" || txtDiaChi.Text == "" || txtHoVaTen.Text == "" || txtSDT.Text == ""
                  || cbQuocTich.Text == "" || cbGioiTinh.Text == "")
            {
                MessageBox.Show("Điền đủ thông tin khách hàng!");
            }
            else
            {
                var filter = ListCustomer.Find(p => p.ID_ == IdCustomer);
                int idCustomerType = ListcustomerTypes.Find(p => p.Name_.CompareTo(cbLoaiKhachHang.Text) == 0).ID_;

                CustomerDTO customer = new CustomerDTO(IdCustomer, txtCMND.Text, idCustomerType, txtHoVaTen.Text, dtpNgaySinh.Value,
                     txtDiaChi.Text, Convert.ToInt32(txtSDT.Text), cbGioiTinh.Text, cbQuocTich.Text);
                CustomerBLL.Instance.Update(customer);
                MessageBox.Show("Update thành công!");
                update();

            }
        }
      
        private void FilterCustomer()
        {
            var filter = ListCustomer.Find(p => p.IDCard_.CompareTo(Cmnd)==0);
               IdCustomer = filter.ID_;
            txtCMND.Text = filter.IDCard_;
            txtDiaChi.Text = filter.Address_;
            txtHoVaTen.Text = filter.Name_;
            cbQuocTich.Text = filter.Nationality_;
            txtSDT.Text = filter.PhoneNumber_.ToString();
            dtpNgaySinh.Value = filter.DateOfBirth_;
          
            
        }

        private void frmUpdateCustomer_Load_1(object sender, EventArgs e)
        {
            FilterCustomer();
            cbLoaiKhachHang.DataSource = ListcustomerTypes;
            cbLoaiKhachHang.DisplayMember = "Name_";
            cbQuocTich.DataSource = Quoctich;
        }
    }
}
