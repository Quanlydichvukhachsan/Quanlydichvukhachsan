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
using DTO.Receive;
using BLL;
using BLL.Receive;
namespace QuanLyKhachSan
{
    public partial class frmdoiphong : Form
    {
        private List<RoomType> ListRoomType = new List<RoomType>();
        private List<RoomDTO> listRoom = new List<RoomDTO>();
        
        private int idRoom;
        private int IdRoom;
      

        public frmdoiphong(int idReceiveRoom ,string nameRoom)
        {
            InitializeComponent();
            ListRoomType = (List<RoomType>)RoomBLL.Instance.LoadRoomType();
            listRoom = (List<RoomDTO>)RoomBLL.Instance.readAll();
            IdReceiveRoom = idReceiveRoom;
            IdRoom = listRoom.Find(p => p.NameRoom.CompareTo(nameRoom) == 0).Id;
       
            
        }
        public int IdReceiveRoom { get; set; }
 
        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string name { get; set; }
            public List<RoomDTO> ListRoom { get; set; }
        }

        public void UpdateRoom()
        {
            UpdateEventArgs args = new UpdateEventArgs { ListRoom = listRoom ,name =txtTenphong.Text };
            EventUpdateHandler.Invoke(this, args);
        }



        private void frmdoiphong_Load(object sender, EventArgs e)
        {
            cbloaiphong.DataSource = ListRoomType;
            cbloaiphong.DisplayMember = "NameRoomType";
            cbloaiphong.ValueMember = "NameRoomType";
        }

        private void cbloaiphong_SelectedValueChanged(object sender, EventArgs e)
        {
            cbphong.Items.Clear();
            string nameRoomType = cbloaiphong.Text;

            var filter = from RoomDTO room in listRoom
                         where room.IdStatusRoom == 1 && room.NameRoomType.CompareTo(nameRoomType) == 0
                         select room;
            txtTenloaiphong.Text = nameRoomType;
            foreach (RoomDTO items in filter)
            {
                cbphong.Items.Add(items.NameRoom);
                cbphong.Text = items.NameRoom;
            }
            txtTenloaiphong.Text = cbphong.Text;
        }

        private void cbphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = listRoom.Find(p => p.NameRoom.CompareTo(cbphong.Text) == 0);
            txtGia.Text = filter.Price.ToString();
            txtTenphong.Text = cbphong.Text;
            txtSonguoitoida.Text = filter.LimitPerson.ToString();
         
            idRoom = filter.Id;
        }

        private void btnluuthaydoi_Click(object sender, EventArgs e)
        {
             if(txtTenphong.Text == "") {
                MessageBox.Show("Chọn phòng cần đổi!");
            }
            else
            {
                string nameRoom = txtTenphong.Text;
                 int id = listRoom.Find(p => p.NameRoom.CompareTo(nameRoom)==0).Id;
                ReceiveRoomDTO receiveRoom = new ReceiveRoomDTO { IdBookRoom = IdReceiveRoom, IdRoom = idRoom };
                ReceiveBLL.Instance.UpdateById(IdReceiveRoom, receiveRoom);
                var items = listRoom.Find(p => p.Id == IdRoom);
            
                RoomDTO room = new RoomDTO(items.NameRoom, 1, items.IdRoomType, items.Id);
                RoomBLL.Instance.UpdateById(IdRoom, room);
                MessageBox.Show("Chuyển phòng thành công!");
                listRoom = (List<RoomDTO>)RoomBLL.Instance.readAll();
                UpdateRoom();

            }
          
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
