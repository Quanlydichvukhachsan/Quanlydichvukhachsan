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
using DTO.Bill;
using BLL.Bill;
using BLL.Service;
namespace QuanLyKhachSan
{
    public partial class frmSudungvathanhtoandichvu : Form
    {
        private List<ServiceTypeDTO> listServieType = new List<ServiceTypeDTO>();
        private List<ServiceDTO> listService = new List<ServiceDTO>();
        public frmSudungvathanhtoandichvu()
        {
            InitializeComponent();
            listServieType = (List<ServiceTypeDTO>)ServiceBLL.Instance.ReadAllServiceType();
            listService = (List <ServiceDTO>)ServiceBLL.Instance.readAll();
        }

        private void frmSudungvathanhtoandichvu_Load(object sender, EventArgs e)
        {

        }
        private void LoadServiceType()
        {
            cbbRoomType.DataSource = listServieType;
            cbbRoomType.DisplayMember = "Name";
            cbbRoomType.ValueMember = "Name";
        }

        private void LoadService()
        {
            cbNameService.DataSource = listService;
            cbNameService.DisplayMember = "Name";
            cbNameService.ValueMember = "Name";
        }


        private void cbbRoomType_Click(object sender, EventArgs e)
        {
            LoadServiceType();
            //LoadService();
        }

        private void cbbRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            cbNameService.Items.Clear();
            var filter = from ServiceDTO service in listService
                         where service.NameServiceType.CompareTo(cbbRoomType.Text) == 0
                         select service;
            foreach (ServiceDTO services in filter)
            {
                cbNameService.Items.Add(services.Name);
                cbNameService.Text = services.Name;
            }
           
        }


        private void cbNameService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNameService.SelectedIndex != null)
            {
                var items = listService.Where(p => p.Name.CompareTo(cbNameService.Text) == 0).ToList();
                if (items.Count >= 0)
                {
                    txtGia.Text = items[0].Price.ToString();

                }
            }
        }


        private void btnAddServie_Click(object sender, EventArgs e)
        {
            /* if(BillRoomPriceBLL.Instance.CheckExistBillRoom() != true)
            {

            } */ 
        }
    }
}
