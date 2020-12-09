using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Receive;
using BLL;
using DTO;
namespace QuanLyKhachSan
{
    public partial class frmChitietnhanhphong : Form
    {
        private  List<CustomerDTO> customers = new List<CustomerDTO>();
        private string Address,numberPhone,National;
     
        private string nameKH="", diachi="", sdt="", cmnd;
        public frmChitietnhanhphong(ReceiveDTO receiveRoom)
        {
            InitializeComponent();
            ReceiveRoom = receiveRoom;

            customers = (List<CustomerDTO>)CustomerBLL.Instance.readAll();

        }
        private ReceiveDTO ReceiveRoom { get; set; }

        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string name { get; set; }
      
        }

        public void UpdateRoom()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            EventUpdateHandler.Invoke(this, args);
        }

        private void frmChitietnhanhphong_Load(object sender, EventArgs e)
        {
            LoadInfoReceive();
        }

        public delegate void UpdateHandlerCus(object sender, UpdateEventArgsCus args);
        public event UpdateHandlerCus EventUpdateHandlerCus;

        public class UpdateEventArgsCus : EventArgs
        {

        }

        public void update()
        {
            UpdateEventArgsCus args = new UpdateEventArgsCus();

            EventUpdateHandlerCus.Invoke(this, args);
        }
        private void btnCapnhatkh_Click(object sender, EventArgs e)
        {
            if (nameKH == "" || cmnd == "" || sdt == "" || diachi == "" )
            {
                MessageBox.Show("Chọn lại khách hàng !");
            }
            else
            {
                 
                if (dtfvDanhsachkhachhang.Rows.Count >= 1 )
                {
                   var cus = customers.Find(p => p.IDCard_.CompareTo(cmnd)==0);
                    if(cus != null)
                    {
                        frmUpdateCustomer frm = new frmUpdateCustomer(cus.IDCard_, customers);
                        frm.EventUpdateHandler += Frm_EventUpdateHandler1;
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không có khách hàng !");
                    }
                }
              
            }
         

        }


        private void Frm_EventUpdateHandler1(object sender, frmUpdateCustomer.UpdateEventArgs args)
        {
            update();
        }

        private void btnDoiphong_Click(object sender, EventArgs e)
        {
            if(txtMaNhanPhong.Text =="" || txtTenphong.Text == "")
            {
                MessageBox.Show("Không có phòng cần chuyển");
            }
            else
            {
                int idReceive = Convert.ToInt32(txtMaNhanPhong.Text);
                frmdoiphong frm = new frmdoiphong(idReceive,txtTenphong.Text);
                frm.EventUpdateHandler += Frm_EventUpdateHandler;
                frm.Show();
            }
            
        }

    

        private void Frm_EventUpdateHandler(object sender, frmdoiphong.UpdateEventArgs args)
        {
            txtTenphong.Text = args.name;
            UpdateRoom();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtfvDanhsachkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameKH = dtfvDanhsachkhachhang[0, e.RowIndex].ToString();
            cmnd = dtfvDanhsachkhachhang[1, e.RowIndex].FormattedValue.ToString();
            sdt = dtfvDanhsachkhachhang[2, e.RowIndex].FormattedValue.ToString();
            diachi = dtfvDanhsachkhachhang[3, e.RowIndex].FormattedValue.ToString();
          
        }

        private void LoadInfoReceive()
        {
            FindCustomer();
            txtNgaynhan.Text = ReceiveRoom.NgayNhan.ToString();
            txtNgaytra.Text = ReceiveRoom.Ngaytra.ToString();
            txtTenphong.Text = ReceiveRoom.NameRoom;
            txtMaNhanPhong.Text = ReceiveRoom.IdBookRoom.ToString();
            dtfvDanhsachkhachhang.Rows[0].Cells[0].Value = ReceiveRoom.NameCustomer;
            dtfvDanhsachkhachhang.Rows[0].Cells[1].Value = ReceiveRoom.CMND;
            dtfvDanhsachkhachhang.Rows[0].Cells[2].Value = Address;
            dtfvDanhsachkhachhang.Rows[0].Cells[3].Value = numberPhone;
            dtfvDanhsachkhachhang.Rows[0].Cells[4].Value = National;
           
        }
        private void FindCustomer()
        {
            var items =  customers.Find(p => p.IDCard_ == ReceiveRoom.CMND);
            Address = items.Address_;
            National = items.Nationality_;
            numberPhone = items.PhoneNumber_.ToString();

        }
    }
}
