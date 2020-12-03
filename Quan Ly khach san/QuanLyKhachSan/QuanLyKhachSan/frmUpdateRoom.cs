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
                List<RoomType> roomTypes = ListRoomType.FindAll(p => p == roomType);
                dataSource.DataSource = roomTypes;

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int n;
            if (txtTimKiemRoom.Text == "")
            {
                dataSource.DataSource = ListRoomType;
            }
            else
            {
                if (txtTimKiemRoom.Text.StartsWith("P") || txtTimKiemRoom.Text.StartsWith("p"))
                {
                    dataSource.DataSource = ListRoomType.Find(p => p.NameRoomType == txtTimKiemRoom.Text);
                }
                else
                {
                    
                    bool isNumeric = int.TryParse(txtTimKiemRoom.Text, out n);
                    if (isNumeric)
                        dataSource.DataSource = ListRoomType.Find(p => p.IdRoomType == n);
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            List<RoomType> roomTypes = null;
              roomTypes = ListRoomType.FindAll(p => p.NameRoomType.CompareTo(txtTenPhong.Text) == 0);
            if(txtTenPhong.Text =="" ||txtSonguoiToiDa.Text =="" ||txtGiaPhong.Text == "")
            {
                  MessageBox.Show("Bạn phải nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                
                if (roomTypes != null )
                {
                    int dem = 0;
                    var filterd = from RoomType p in ListRoomType
                                  where p.NameRoomType.CompareTo(roomTypes[0].NameRoomType) == 0
                                  select p;
                    dem = filterd.Count();
                    if(dem == 0 || roomTypes[0].NameRoomType.CompareTo(txtTenPhong.Text)==0)
                    {
                         
                        if(MessageBox.Show("Bạn Có muốn update ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            roomTypes[0].Price = Convert.ToInt32(txtGiaPhong.Text);
                            roomTypes[0].LimitPerson = Convert.ToInt32(txtSonguoiToiDa.Text);
                            roomTypes[0].NameRoomType = txtTenPhong.Text;
                            roomTypes[0].DayUpdate = DateTime.Now;
                            roomTypes[0].Notes = "";
                            RoomBLL.Instance.UpdateRoomType(roomTypes[0]);
                            RoomBLL.Instance.InsertRoomTypeUpdateDay(roomTypes[0]);
                            MessageBox.Show("Update Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Hủy Update!");
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Đã có tên phòng trong dannh sách!", "Thông báo", MessageBoxButtons.OK);
                    }
              
                }
                else
                { 
                    MessageBox.Show("Không tồn tại tên Phòng", "Thông báo", MessageBoxButtons.OK);
                }
            }
         
        }
    }
}
