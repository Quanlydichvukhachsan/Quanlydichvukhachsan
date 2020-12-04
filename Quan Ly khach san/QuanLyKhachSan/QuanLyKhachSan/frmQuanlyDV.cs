using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Service;
using BLL.Service;
namespace QuanLyKhachSan
{
    public partial class frmQuanlyDV : Form
    {
        BindingSource dataSource = new BindingSource();
        private List<int> ListIdServive = new List<int>();
        private List<ServiceDTO> ListService = new List<ServiceDTO>();
        private List<ServiceTypeDTO> ListServiceTypre = new List<ServiceTypeDTO>();
        public frmQuanlyDV()
        {
            InitializeComponent();
            ListServiceTypre = (List <ServiceTypeDTO>)ServiceBLL.Instance.ReadAllServiceType();
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
            dtgvDichVu.Rows.Clear();
            dtgvDichVu.AutoGenerateColumns = false;
            dataSource.DataSource = ListService ;
        }
        private void InitComboBox()
        {
            
            foreach (var items in ListService)
            {
                ListIdServive.Add(items.ID);
            }
        }
        private void  LoadIdService()
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
              

                // dataSource.DataSource = serviceTypes;
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
                dataSource.DataSource = serviceTypes;
                
               
            }  
        }




        private void cbbMaLoaidichvuLDV_Click(object sender, EventArgs e)
        {
            LoadServiceType();
        }

        private void btnTimkiemLDV_Click(object sender, EventArgs e)
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
    }
}
