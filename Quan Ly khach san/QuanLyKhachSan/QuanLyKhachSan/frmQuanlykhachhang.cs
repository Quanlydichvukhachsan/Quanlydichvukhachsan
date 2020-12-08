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
    public partial class frmQuanlykhachhang : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private List<string> gioiTinh = new List<string>() { "Nam", "Nữ" };
        private List<string> Quoctich = new List<string>() { "Lào", "Mỹ", "Châu phi", "Ấn Độ", "Hoa kỳ", "Mỹ Đen", "Việt Nam", "Trung Quốc", "Nhật Bản", "Singapore" };
        private List<CustomerTypeDTO> listCustomerType = new List<CustomerTypeDTO>();
        private List<CustomerDTO> listCustomer = new List<CustomerDTO>();
        public frmQuanlykhachhang()
        {
            InitializeComponent();
        }     
        private void frmQuanlykhachhang_Load(object sender, EventArgs e)
        {
            dtgvDSKH.DataSource = bindingSource;
            dtgvDSKH.AutoGenerateColumns = false;
            listCustomer =(List<CustomerDTO>)CustomerBLL.Instance.readAll();
             listCustomerType =  (List<CustomerTypeDTO>)CustomerBLL.Instance.LoadCustomerType();
            LoadDgvCustomer();
        }
        public void LoadDgvCustomer()
        {
            bindingSource.DataSource = listCustomer;
            LoadCboxCustomerType();
            cbQuoctich.DataSource = Quoctich;
            cbGioitinh.DataSource = gioiTinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHovaten.Text == "" || txtHovaten.Text.Length <= 10 || mtbInsertIdCard.Text == ""|| mtbInsertIdCard.Text.Length != 9 ||
              mtbSDT.Text == "" || mtbSDT.Text.Length != 10 || txtDiachi.Text == "")
                MessageBox.Show("Kiểm tra lại thông tin khách hàng", "Cảnh báo", MessageBoxButtons.OK);
            else
            {
                var fillterIdCard = from CustomerDTO cus in listCustomer
                                    where cus.IDCard_.CompareTo(mtbInsertIdCard.Text) == 0
                                    select cus;
                if (fillterIdCard.Count() == 0)
                {
                    string nameCustomer = cbLoaikhachhang.GetItemText(cbLoaikhachhang.SelectedValue.ToString());  
                    var fillterName = listCustomerType.Find(p => p.Name_.CompareTo(nameCustomer) == 0);
                    int idCustomer = fillterName.ID_;
                    CustomerDTO customer = new CustomerDTO(mtbInsertIdCard.Text, idCustomer, txtHovaten.Text, dtpNgaysinh.Value, txtDiachi.Text,
                        mtbSDT.Text, cbGioitinh.Text, cbQuoctich.Text);
                  
                    CustomerBLL.Instance.Insert(customer);
                    MessageBox.Show("Thêm khách hàng thành công");
                    listCustomer = (List<CustomerDTO>)CustomerBLL.Instance.readAll();
                    LoadDgvCustomer();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại khách hàng");
                }                   
            }
        }
        public void LoadCboxCustomerType()
        {
            cbLoaikhachhang.DataSource =listCustomerType;
            cbLoaikhachhang.DisplayMember = "Name_";
            cbLoaikhachhang.ValueMember = "Name_";
        }

        private void dtgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgvDSKH[0, e.RowIndex].FormattedValue.ToString();
            txtHovaten.Text = dtgvDSKH[1, e.RowIndex].FormattedValue.ToString();
            mtbInsertIdCard.Text = dtgvDSKH[2, e.RowIndex].FormattedValue.ToString();
            cbLoaikhachhang.Text = dtgvDSKH[3, e.RowIndex].FormattedValue.ToString();
            cbGioitinh.Text = dtgvDSKH[4, e.RowIndex].FormattedValue.ToString();
            dtpNgaysinh.Text = dtgvDSKH[5, e.RowIndex].FormattedValue.ToString();
            mtbSDT.Text = dtgvDSKH[6, e.RowIndex].FormattedValue.ToString();
            txtDiachi.Text = dtgvDSKH[7, e.RowIndex].FormattedValue.ToString();
            cbQuoctich.Text = dtgvDSKH[8, e.RowIndex].FormattedValue.ToString();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            
            if (txtHovaten.Text == "" || txtHovaten.Text.Length <= 10 || mtbInsertIdCard.Text == "" || mtbInsertIdCard.Text.Length != 9 ||
             mtbSDT.Text == "" || mtbSDT.Text.Length != 10 || txtDiachi.Text == "")
                MessageBox.Show("Kiểm tra lại thông tin Cập Nhật", "Cảnh báo", MessageBoxButtons.OK);
            else
            {
                string preIdcard = null;
                int id =0 ;
                if (dtgvDSKH.SelectedCells.Count >0)
                {
                    int selectedRowIndex = dtgvDSKH.SelectedCells[0].RowIndex;
                    DataGridViewRow viewRow = dtgvDSKH.Rows[selectedRowIndex];
                    preIdcard = Convert.ToString(viewRow.Cells["IDCard_"].Value);
                    id = Convert.ToInt32(viewRow.Cells["ID_"].Value);
                }

                var result = from CustomerDTO idC in listCustomer
                                 where idC.IDCard_.CompareTo(mtbInsertIdCard.Text) == 0
                                 select idC;
                if (result.Count() ==0 || mtbInsertIdCard.Text == preIdcard)
                {
                    string nameCustomerType = cbLoaikhachhang.GetItemText(cbLoaikhachhang.SelectedValue.ToString());
                    var filterCustomerType = listCustomerType.Find(p => p.Name_.CompareTo(nameCustomerType) ==0);
                    int idCusType = filterCustomerType.ID_;
                    CustomerDTO customer = new CustomerDTO( id, mtbInsertIdCard.Text, idCusType, txtHovaten.Text, dtpNgaysinh.Value, txtDiachi.Text,
                      mtbSDT.Text, cbGioitinh.Text, cbQuoctich.Text);
                    CustomerBLL.Instance.Update(customer);
                    MessageBox.Show("Cập nhật khách hàng thành công");
                    listCustomer = (List<CustomerDTO>)CustomerBLL.Instance.readAll();
                    LoadDgvCustomer();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }    
        }
    }
}
