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
namespace QuanLyKhachSan
{
    public partial class frmUpdateRoom : Form
    {
        public List<RoomType> ListRoomType { get; private set; }
        private BindingSource dataSource = new BindingSource();
        public frmUpdateRoom(List<RoomType> listRoomType)
        {
            InitializeComponent();
            ListRoomType = new List<RoomType>();
            ListRoomType = listRoomType;
        }


        private void frmUpdateRoom_Load(object sender, EventArgs e)
        {
            dtgvRoomType.DataSource = dataSource;
            LoadingRoomType();
        }

        private void LoadingRoomType()
        {
            dataSource.DataSource = ListRoomType;
           cbbMaLoaiPhong.DataSource = null;
          
        }

        private void cbbMaLoaiPhong_Click(object sender, EventArgs e)
        {

            cbbMaLoaiPhong.DataSource = ListRoomType;
            cbbMaLoaiPhong.DisplayMember = "IdRoomType";
            cbbMaLoaiPhong.ValueMember = "IdRoomType";
         
        }

        private void  cbbMaLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbMaLoaiPhong.SelectedValue != null)
            {
                int i = cbbMaLoaiPhong.SelectedIndex;
          
                RoomType roomType = cbbMaLoaiPhong.Items[i] as RoomType;
                txtGiaPhong.Text = roomType.Price+"";
                 txtSonguoiToiDa.Text = roomType.LimitPerson.ToString();
                txtTenPhong.Text = roomType.NameRoomType;
              /* int index = ListRoomType.FindIndex(p=>p.IdRoomType == roomType.IdRoomType);
                for (int j = 0; j < dtgvRoomType.Rows.Count; j++)
                {
                    if (j != 2)
                    {
                        dtgvRoomType.Rows.RemoveAt(j);
                        dtgvRoomType.Refresh();
                    }
                }*/


            }
      

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            LoadingRoomType();
            Reset();
        }
        private void Reset()
        {
            txtGiaPhong.Text = "";
            txtSonguoiToiDa.Text = "";
            txtTenPhong.Text = "";
            txtTimKiemRoom.Text = "";
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
           
        }
    }
}
