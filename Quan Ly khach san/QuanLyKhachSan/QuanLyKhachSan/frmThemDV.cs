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
    public partial class frmThemDV : Form
    {
        public frmThemDV(List<ServiceTypeDTO> listServiceTypre)
        {
            InitializeComponent();
            ListServiceTypre = listServiceTypre;

        }
        private List<ServiceTypeDTO> ListServiceTypre = new List<ServiceTypeDTO>();
        private void frmThemDV_Load(object sender, EventArgs e)
        {
            cbMaDV.DataSource = ListServiceTypre;
            cbMaDV.DisplayMember = "Name";
            cbMaDV.ValueMember = "Name";
        }

        
        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string name { get; set; }
        }

        public void Update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            EventUpdateHandler.Invoke(this, args);
        }
        private void btncthemdichvu_Click(object sender, EventArgs e)
        {
            int price = 0;
            string nameServiceType = cbMaDV.Text;
          
            if(txtTenLoaidichvuLDV.Text =="" || txtGiaLDV.Text == "" ||cbMaDV.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");

            }
            else
            {
                var filter = ListServiceTypre.Find(p => p.Name.CompareTo(nameServiceType) == 0);
                bool checkPrice = int.TryParse(txtGiaLDV.Text, out price);
                 if (checkPrice)
                 {

                     ServiceBLL.Instance.Insert(new ServiceDTO {Name =txtTenLoaidichvuLDV.Text ,Price =price, IdService =filter.ID });
                    MessageBox.Show("Thêm dịch vụ thành công !");
                    Update();
                }
                 else
                 {
                     MessageBox.Show("Bạn không được nhập chữ!");
                 }
            }
        }

     
    }
}
