using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmQLPhong : Form
    {
        private List<int> ListIdRoom = null;
        private IEnumerable<RoomType> ListRoomType = null;
        private IEnumerable<StatusRoom> ListStatusRoom = null;
        private List<RoomDTO> ListRoom = null;
        private BindingSource dataSource = new BindingSource();
        private BindingSource dataSourceTypeRoom = new BindingSource();

        private string nameRoom, nameTypeRoom;
        private string IsnameRoom = "";
        private int iD, idRoom = 0, idTypeRoom = 0;
        private string IsstatusRoom = "";
        private int statusRoom = 1;

        public frmQLPhong()
        {
            InitializeComponent();

            ListRoom = new List<RoomDTO>();
            ListRoomType = new List<RoomType>();
            ListStatusRoom = new List<StatusRoom>();
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            dtgvDanhsachPhongQLP.DataSource = dataSource;
            InitComboBox();
            LoadRoom();
         
            AddBinding();
        }

        private void InitComboBox()
        {
            ListRoom = (List<RoomDTO>)RoomBLL.Instance.readAll();
            ListStatusRoom = RoomBLL.Instance.LoadStatusRoom();
            ListRoomType = RoomBLL.Instance.LoadRoomType();
            ListIdRoom = new List<int>();
            foreach (var items in ListRoom)
            {
                ListIdRoom.Add(items.Id);
            }
        }
        private void LoadRoom()
        {
           
            textBox1.Text = ListRoom.Count.ToString();
            dtgvDanhsachPhongQLP.Rows.Clear();
            dtgvDanhsachPhongQLP.AutoGenerateColumns = false;
            dataSource.DataSource = ListRoom;
            SetComboxDeFaultNull();
        }
        private void SetComboxDeFaultNull()
        {
            cbStatusRoom.DataSource = null;
            cbbMaPhongQLP.DataSource = null;
            cbbLoaiPhongQLP.DataSource = null;
        }

        private void SetComboxClick()
        {
            LoadIdRoom();
            LoadRoomType();
            LoadStatusRoom();
        }

        private void InitPropertiesRoom()
        {
            string getIdByName = cbbLoaiPhongQLP.GetItemText(this.cbbLoaiPhongQLP.SelectedValue.ToString());
            iD = int.Parse(getIdByName);
            idRoom = Convert.ToInt32(cbbMaPhongQLP.GetItemText(this.cbbMaPhongQLP.SelectedItem.ToString()));
        }

        private void LoadIdRoom()
        {
           

            cbbMaPhongQLP.DataSource = ListIdRoom;
        }

        private void LoadStatusRoom()
        {
        
            cbStatusRoom.DataSource = ListStatusRoom;
            cbStatusRoom.DisplayMember = "NameStatusRoom";
            cbStatusRoom.ValueMember = "NameStatusRoom";
        }

        private void LoadRoomType()
        {
        
            cbbLoaiPhongQLP.DataSource = ListRoomType;

            cbbLoaiPhongQLP.DisplayMember = "NameRoomType";
            cbbLoaiPhongQLP.ValueMember = "NameRoomType";
        }

        private void AddBinding()
        {
            /*  txtSoNguoiToiDa.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Limitperson"));
              txtGiaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Price"));
              txtTenPhong.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "NameRoom"));
              cbbLoaiPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameRoomType"));
              cbStatusRoom.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameStatusRoom"));
              cbbMaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "ID"));*/
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
            foreach (RoomType roomType in ListRoomType)
            {
                toolStripComboBoxTypeRoom.Items.Add(roomType.NameRoomType);
            }
        }

        private void cbbMaPhongQLP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMaPhongQLP.SelectedItem != null)
            {
                string idRoom = cbbMaPhongQLP.GetItemText(this.cbbMaPhongQLP.SelectedItem.ToString());

                var filterd = from RoomDTO p in ListRoom
                              where p.Id == Convert.ToInt32(idRoom)
                              select p;

                foreach (RoomDTO room in filterd)
                {
                    txtGiaPhongQLP.Text = room.Price.ToString();
                    txtTenPhong.Text = room.NameRoom;
                    cbStatusRoom.Text = room.NameStatusRoom;
                    txtSoNguoiToiDa.Text = room.LimitPerson.ToString();
                    foreach (RoomType roomtype in ListRoomType.ToList().FindAll(p => p.NameRoomType == room.NameRoomType))
                    {
                        cbbLoaiPhongQLP.Text = roomtype.NameRoomType;
                    }
                }
            }
        }

        private void cbbLoaiPhongQLP_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if (cbbLoaiPhongQLP.SelectedItem != null )
            {
                string NameTypeRoom = cbbLoaiPhongQLP.GetItemText(cbbLoaiPhongQLP.SelectedValue.ToString());

                var filterd = from RoomDTO p in ListRoom
                              where p.NameRoomType == NameTypeRoom
                              select p;
                List<int> fillId = new List<int>();
                List<RoomDTO> FillRoom = new List<RoomDTO>();
                foreach (RoomDTO room in filterd)
                {
                    txtGiaPhongQLP.Text = room.Price.ToString();
                    txtTenPhong.Text = room.NameRoom;
                    cbStatusRoom.Text = room.NameStatusRoom;
                    txtSoNguoiToiDa.Text = room.LimitPerson.ToString();
                    fillId.Add(room.Id);
                    FillRoom = ListRoom.FindAll(p => p.NameRoomType.CompareTo(room.NameRoomType) == 0);
                }

                dataSource.DataSource = FillRoom;
                cbbMaPhongQLP.DataSource = fillId;
            }
        }

        private void cbStatusRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbStatusRoom.SelectedItem != null)
            {
                string StatusRoom = cbStatusRoom.GetItemText(cbStatusRoom.SelectedValue.ToString());
                List<RoomDTO> rooms = ListRoom.FindAll(p => p.NameStatusRoom.CompareTo(StatusRoom) == 0);
                dataSource.DataSource = rooms;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            LoadRoom();
            txtGiaPhongQLP.Text = "";
            txtTenPhong.Text = "";
            txtTimKiemRoom.Text = "";
        }

        private void updateRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsstatusRoom.CompareTo("Trống") != 0)
            {
                MessageBox.Show("Phòng đã có người", "Thông báo", MessageBoxButtons.OK);
                gunaContextMenuStrip1.Close();
            }
        }

        private void cbbLoaiPhongQLP_Click(object sender, EventArgs e)
        {
            //LoadRoomType();
            SetComboxClick();
        }

        private void cbbMaPhongQLP_Click(object sender, EventArgs e)
        {
            //   LoadIdRoom();
            SetComboxClick();
        }

        private void cbStatusRoom_Click(object sender, EventArgs e)
        {
            //  LoadStatusRoom();
            SetComboxClick();
        }

        private void UpdateRoomType_Click(object sender, EventArgs e)
        {
            frmUpdateRoom frm = new frmUpdateRoom((List<RoomType>)ListRoomType);
            frm.Show();
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
            string nameStatus = toolStripComboBoxStatusRoom.Text;
            if (!string.IsNullOrEmpty(toolStripTextBoxNameRoom.Text))
            {
                bool IsnumberRoom = int.TryParse(toolStripTextBoxNameRoom.Text, out n);
                if (IsnumberRoom)
                {
                    IsnameRoom = "Phòng " + n;
                }
                else
                {
                    MessageBox.Show("Chỉ được nhập số");
                    IsnameRoom = nameRoom;
                }
            }
            else
            {
                IsnameRoom = nameRoom;
            }

            int idStatusRoom = 1;
            if (nameStatus.CompareTo("Trống") != 0) { idStatusRoom = 2; }
            ListRoomType.ToList().FindAll(p => p.NameRoomType.CompareTo(name) == 0).ForEach(p => idTypeRoom = p.IdRoomType);

            int count = 0;
            count = IsNameInvalid().Count();

            if (IsnameRoom.CompareTo(nameRoom) == 0 || count == 0)
            {
                RoomDTO room = new RoomDTO(nameRoom: IsnameRoom, idStatusRoom: idStatusRoom, idRoomType: idTypeRoom, id: idRoom);
                if (RoomBLL.Instance.UpdateById(idRoom, room))
                {
                    MessageBox.Show("Update Successfully");
                    LoadRoom();
                    Reset();
                }
            }
            else if (IsstatusRoom.CompareTo("Trống") != 0)
            {
                MessageBox.Show("Phòng đã có người");
                Reset();
            }
            else
            {
                MessageBox.Show("Name Room Exist");
                Reset();
            }
        }

        private void Reset()
        {
            toolStripComboBoxTypeRoom.Text = "";
            toolStripComboBoxStatusRoom.Text = "";
            toolStripTextBoxNameRoom.Text = "";
        }
    }
}