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
        private List<int> ListIdRoom = null;
        private IEnumerable<RoomType> ListRoomType = null;  
        private List<RoomDTO> ListRoom = null;
        private BindingSource dataSource = new BindingSource();
        private string nameRoom ,nameTypeRoom;
        private string IsnameRoom;
        private int iD, idRoom =0,idTypeRoom=0;
        private string IsstatusRoom ="";
        int statusRoom = 1;
      
        public frmQLPhong()
        {
            InitializeComponent();
         
            ListRoom = new List<RoomDTO>();
            ListIdRoom = new List<int>();
            ListRoomType = new List<RoomType>();

        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {

            dtgvDanhsachPhongQLP.DataSource = dataSource;
            LoadRoom();
            AddBinding();
          


        }

        private void LoadRoom()
        {


            ListRoom = (List<RoomDTO>)RoomBLL.Instance.readAll();
            dtgvDanhsachPhongQLP.AutoGenerateColumns = false;
            dataSource.DataSource = ListRoom;
            LoadStatusRoom();
            LoadRoomType();
            LoadIdRoom();


        }
        private void InitPropertiesRoom()
        {
            string getIdByName = cbbLoaiPhongQLP.GetItemText(this.cbbLoaiPhongQLP.SelectedValue.ToString());
            iD = int.Parse(getIdByName);
            idRoom = Convert.ToInt32(cbbMaPhongQLP.GetItemText(this.cbbMaPhongQLP.SelectedItem.ToString()));
        }

        private void LoadIdRoom()
        {
            foreach (var items in ListRoom)
            {
                ListIdRoom.Add(items.Id);

            }
            cbbMaPhongQLP.DataSource = ListIdRoom;

        }
        private void LoadStatusRoom()
        {
            cbStatusRoom.DataSource = RoomBLL.Instance.LoadStatusRoom();
            cbStatusRoom.DisplayMember = "NameStatusRoom";
            cbStatusRoom.ValueMember = "IdStatusRoom";

        }
        private void LoadRoomType()
        {
          
            ListRoomType = RoomBLL.Instance.LoadRoomType();
            cbbLoaiPhongQLP.DataSource = ListRoomType;
            
            cbbLoaiPhongQLP.DisplayMember = "NameRoomType";
            cbbLoaiPhongQLP.ValueMember = "IdRoomType";
        }

        private void AddBinding()
        {
            
            txtSoNguoiToiDa.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Limitperson"));
            txtGiaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Price"));
            txtTenPhong.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "NameRoom"));
            cbbLoaiPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameRoomType"));
            cbStatusRoom.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameStatusRoom"));
            cbbMaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "ID"));
           
            


        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            int n;


            if (txtTimKiemRoom.Text == "")
            {
                dataSource.DataSource = ListRoom;
            }
            else
            {
                if (txtTimKiemRoom.Text.StartsWith("P") || txtTimKiemRoom.Text.StartsWith("p"))
                {
                    dataSource.DataSource = ListRoom.Find(p => p.NameRoom == txtTimKiemRoom.Text);
                }
                else
                {
                    bool isNumeric = int.TryParse(txtTimKiemRoom.Text, out n);
                    if (isNumeric)
                        dataSource.DataSource = ListRoom.Find(p => p.Id == n);
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                }

            }

        }
        private IEnumerable<RoomDTO> IsNameInvalid()
        {
            IEnumerable<RoomDTO> filtered = from RoomDTO i in ListRoom
                                            where i.NameRoom.CompareTo(IsnameRoom) == 0
                                            select i;
            return filtered;
        }
        private void btnThemPhongQLP_Click(object sender, EventArgs e)
        {

            int count = IsNameInvalid().Count();
            if (count == 0)
            {
                RoomDTO room = new RoomDTO(nameRoom: txtTenPhong.Text, idStatusRoom: statusRoom, idRoomType: iD, id: 0);
                RoomBLL.Instance.Insert(room);
                LoadRoom();
                MessageBox.Show("Insert Successfully");
            }
            else
            {
                MessageBox.Show("Name Room Exist");
            }

        }

       

     
        private void dtgvDanhsachPhongQLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRoom = Convert.ToInt32(dtgvDanhsachPhongQLP[0, e.RowIndex].FormattedValue.ToString());
            nameRoom = dtgvDanhsachPhongQLP[1, e.RowIndex].FormattedValue.ToString();
            IsstatusRoom = dtgvDanhsachPhongQLP[5, e.RowIndex].FormattedValue.ToString();
            nameTypeRoom = dtgvDanhsachPhongQLP[2, e.RowIndex].FormattedValue.ToString();
            ListRoomType.ToList().FindAll(p => p.NameRoomType.CompareTo(nameTypeRoom) == 0).ForEach(p => idTypeRoom = p.IdRoomType);

        }
        //load cbTypeRoom
        private void typeRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
             foreach(RoomType roomType in ListRoomType)
            {
                toolStripComboBoxTypeRoom.Items.Add(roomType.NameRoomType);
             
            }
          
        }

        private void updateRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsstatusRoom.CompareTo("Trống") != 0)
            {

                MessageBox.Show("Phòng đã có người", "Thông báo", MessageBoxButtons.OK);
                gunaContextMenuStrip1.Close();
            }
        }

        //Update
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateRoom();

        }
     

    

        private void UpdateRoom()
        {
            int n;
          
            string name = toolStripComboBoxTypeRoom.Text;     
            string nameStatus = toolStripComboBoxStatusRoom.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(toolStripTextBoxNameRoom.Text))
            {
                bool IsnumberRoom = int.TryParse(toolStripTextBoxNameRoom.Text, out n);
                if (IsnumberRoom)
                {
                    IsnameRoom = "Phòng " + n;
                }
            }
            else
            {
                IsnameRoom = nameRoom;
            }
           
            int idStatusRoom = 1;
            if (nameStatus.CompareTo("Trống") != 0) { idStatusRoom = 2; }
            ListRoomType.ToList().FindAll(p => p.NameRoomType.CompareTo(name) == 0).ForEach(p => idTypeRoom = p.IdRoomType);

           // InitPropertiesRoom();
            int count = 0;
            count = IsNameInvalid().Count();

            if (IsnameRoom.CompareTo(nameRoom) == 0|| count == 0  )
            {
              
                RoomDTO room = new RoomDTO(nameRoom: IsnameRoom, idStatusRoom: idStatusRoom, idRoomType: idTypeRoom, id: idRoom);
                if (RoomBLL.Instance.UpdateById(idRoom, room))
                {
                    MessageBox.Show("Update Successfully");
                    LoadIdRoom();
                }

            }
            else if (IsstatusRoom.CompareTo("Trống") != 0)
            {
                MessageBox.Show("Phòng đã có người");
            }
            else
            {
                MessageBox.Show("Name Room Exist");
            }
        }

    }
}
