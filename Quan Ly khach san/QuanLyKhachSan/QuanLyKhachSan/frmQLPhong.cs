using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QuanLyKhachSan
{
    public partial class frmQLPhong : Form
    {
        public frmQLPhong()
        {
            InitializeComponent();
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            LoadRoom();      
        }
        private void LoadRoom()
        {
            int i = 0;
            dtgvDanhsachPhongQLP.Rows.Clear();
             foreach (RoomDTO items in  RoomBLL.Instance.readAll())
             {

                dtgvDanhsachPhongQLP.Rows.Add();
                dtgvDanhsachPhongQLP.Rows[i].Cells[0].Value = items.Id;
                dtgvDanhsachPhongQLP.Rows[i].Cells[1].Value = items.NameRoom;
                dtgvDanhsachPhongQLP.Rows[i].Cells[2].Value = items.NameRoomType;
                dtgvDanhsachPhongQLP.Rows[i].Cells[3].Value = items.Price;
                dtgvDanhsachPhongQLP.Rows[i].Cells[4].Value = items.LimitPerson;
                dtgvDanhsachPhongQLP.Rows[i].Cells[5].Value = items.NameStatusRoom;
                i++;
             }
          
        
        }
    }
}
