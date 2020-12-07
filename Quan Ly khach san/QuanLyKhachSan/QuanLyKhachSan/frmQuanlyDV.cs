using BLL.Service;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmQuanlyDV : Form
    {
        private BindingSource dataSource = new BindingSource();
        private List<int> ListIdServive = new List<int>();
        private List<ServiceDTO> ListService = new List<ServiceDTO>();
        private List<ServiceTypeDTO> ListServiceTypre = new List<ServiceTypeDTO>();
        private int Id = 0;
        private int price;
        private string nameService, nameServiceTypeOrigin;

        public frmQuanlyDV()
        {
            InitializeComponent();
            ListServiceTypre = (List<ServiceTypeDTO>)ServiceBLL.Instance.ReadAllServiceType();
        }

        private void frmQuanlyDV_Load(object sender, EventArgs e)
        {
            dtgvDichVu.DataSource = dataSource;
            ListService = (List<ServiceDTO>)ServiceBLL.Instance.readAll();
            LoadService();
            InitComboBox();
            SetComboxDeFaultNull();
        }

        private void LoadService()
        {
            dtgvDichVu.AutoGenerateColumns = false;
            dataSource.DataSource = ListService;
        }

        private void InitComboBox()
        {
            foreach (var items in ListService)
            {
                ListIdServive.Add(items.ID);
            }
        }

        private void LoadIdService()
        {
            cbMaDV.DataSource = ListIdServive;
        }

        private void LoadServiceType()
        {
            cbbMaLoaidichvuLDV.DataSource = ListServiceTypre;
            cbbMaLoaidichvuLDV.DisplayMember = "Name";
            cbbMaLoaidichvuLDV.ValueMember = "Name";
        }

        private void FindService()
        {
            int n;

            if (txtTimkiemLoaidichvuLDV.Text == "")
            {
                dataSource.DataSource = ListService;
            }
            else
            {
                bool isNumeric = int.TryParse(txtTimkiemLoaidichvuLDV.Text, out n);
                if (isNumeric)
                    dataSource.DataSource = ListService.Find(p => p.ID == n);
                else
                {
                    var filter = ListService.Find(p => p.Name.CompareTo(txtTimkiemLoaidichvuLDV.Text.Trim()) == 0);
                    if (filter == null)
                    {
                        MessageBox.Show("Không có tên dịch vụ cần tìm!");
                    }
                    else
                    {
                        dataSource.DataSource = ListService.Find(p => p.Name.CompareTo(filter.Name) == 0);
                    }
                }
            }
        }

        private void cbMaDV_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbMaDV.SelectedItem != null)
            {
                string IdServiceType = cbMaDV.GetItemText(cbMaDV.SelectedValue.ToString());
                List<ServiceDTO> serviceTypes = ListService.FindAll(p => p.ID == Convert.ToInt32(IdServiceType));
                List<ServiceTypeDTO> listServiceType = new List<ServiceTypeDTO>();
                foreach (ServiceDTO service in serviceTypes)
                {
                    txtGiaLDV.Text = service.Price.ToString();
                    txtTenLoaidichvuLDV.Text = service.Name;
                }
             
              //   dataSource.DataSource = serviceTypes;
            }
        }

        private void SetComboxDeFaultNull()
        {
            cbbMaLoaidichvuLDV.DataSource = null;
            cbMaDV.DataSource = null;
        }

        private void cbMaDV_Click(object sender, EventArgs e)
        {
            LoadIdService();
        }

        private void cbbMaLoaidichvuLDV_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMaLoaidichvuLDV.SelectedItem != null)
            {
                string ServiceType = cbbMaLoaidichvuLDV.GetItemText(cbbMaLoaidichvuLDV.SelectedValue.ToString());

                List<ServiceDTO> serviceTypes = ListService.FindAll(p => p.NameServiceType.CompareTo(ServiceType) == 0);
                List<int> listId = new List<int>();
                foreach (ServiceDTO service in serviceTypes)
                {
                    txtGiaLDV.Text = service.Price.ToString();
                    txtTenLoaidichvuLDV.Text = service.Name;
                    listId.Add(service.ID);
                }
                cbMaDV.DataSource = listId;
               
            }
        }

        private void cbbMaLoaidichvuLDV_Click(object sender, EventArgs e)
        {
            LoadServiceType();
        }

        private void btnTimkiemLDV_Click(object sender, EventArgs e)
        {
            FindService();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            cbbMaLoaidichvuLDV.DataSource = null;
            cbMaDV.DataSource = null;
            txtGiaLDV.Text = "";
            txtTenLoaidichvuLDV.Text = "";
            txtTimkiemLoaidichvuLDV.Text = "";
            LoadService();
        }

        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại dịch vụ !");
            }
            else
            {
                var servicetype = ListServiceTypre.Find(p => p.Name.CompareTo(toolStripTextBox.Text) == 0);
                if (servicetype == null)
                {
                    ServiceTypeDTO serviceType = new ServiceTypeDTO { Name = toolStripTextBox.Text };
                    if (ServiceBLL.Instance.InsertType(serviceType))
                    {
                        MessageBox.Show("Thêm loại dịch vụ thành công");
                        ListServiceTypre = (List<ServiceTypeDTO>)ServiceBLL.Instance.ReadAllServiceType();
                    }
                }
                else
                {
                    MessageBox.Show("Đã có tên trong danh sách  loại dịch vụ !");
                }
            }
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameServiceType = toolStripComboBoxloaiDV.Text;
            if (nameServiceType == "") nameServiceType = nameServiceTypeOrigin;
            var items = ListServiceTypre.Find(p => p.Name.CompareTo(nameServiceType) == 0);

            nameService = toolStripTextBoxTenDV.Text;
            if (Id == 0) MessageBox.Show("Chọn lại dịch vụ cần update!");
            if (nameService == "" || price == 0 || nameServiceType == "" )
            {
                MessageBox.Show("Bạn chưa điền đẩy đủ thông tin!");
            }
            else
            {
                bool checkPrice = int.TryParse(toolStripTextBoxGiaDV.Text, out price);
                if (checkPrice)
                {
                    ServiceDTO service = new ServiceDTO { ID = Id, IdService = items.ID, Price = price, Name = nameService };
                    if (ServiceBLL.Instance.UpdateById(Id, service))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        ListService = (List<ServiceDTO>)ServiceBLL.Instance.readAll();
                        LoadService();
                    }
                }
                else
                {
                    MessageBox.Show("Không được nhập chữ!");
                }
            }
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ServiceTypeDTO serviceType in ListServiceTypre)
            {
                toolStripComboBoxloaiDV.Items.Add(serviceType.Name);
            }
            toolStripTextBoxTenDV.Text = nameService;
            toolStripTextBoxGiaDV.Text =Convert.ToString(price);

        }

        private void xóaDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (Id == 0) MessageBox.Show("Chọn lại loại dịch vụ muốn xóa");
                else
                {
                    if (ServiceBLL.Instance.DeleteById(Id.ToString())==true)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa vì ảnh hưởng đến kết quả Hóa đơn thanh toán,Hãy xóa hóa đơn có loại dịch vụ (" + nameService + ")", "Thông báo", MessageBoxButtons.OK);
                    }
                }
               
            }
          
        }

        private void btnThemDichvuDV_Click(object sender, EventArgs e)
        {
            frmThemDV frm = new frmThemDV(ListServiceTypre);
            frm.EventUpdateHandler += Frm_EventUpdateHandler;
            frm.Show();
        }

        private void Frm_EventUpdateHandler(object sender, frmThemDV.UpdateEventArgs args)
        {
            ListService = (List<ServiceDTO>)ServiceBLL.Instance.readAll();
            LoadService();
        }

        private void dtgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dtgvDichVu[0, e.RowIndex].FormattedValue.ToString());
            nameService = dtgvDichVu[1, e.RowIndex].FormattedValue.ToString();
            price = Convert.ToInt32(dtgvDichVu[2, e.RowIndex].FormattedValue.ToString());
            nameServiceTypeOrigin = dtgvDichVu[3, e.RowIndex].FormattedValue.ToString();
        }
    }
}