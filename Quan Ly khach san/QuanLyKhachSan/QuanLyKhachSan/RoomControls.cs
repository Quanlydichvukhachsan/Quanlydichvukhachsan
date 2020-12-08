using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using DTO;
using BLL;
using DTO.Bill;
using BLL.Bill;
using System.Linq;

namespace QuanLyKhachSan
{
    public partial class RoomControls : UserControl
    {
        public RoomControls()
        {
            InitializeComponent();
         
           
        }
      
        private int _id;
        private int _idReceive;
        private int _idBookRoom;
        private string _name;
        private Image _img;
        private Color _color;
        public string NameRoom { get { return _name; } set { _name = value;  lbRoom.Text = value; } }
        public Image ImgRoom { get { return _img; } set { _img = value; pictureBoxRoom.Image = value; } }

      
        public Color ColorRoom
        {
            get { return _color; }
            set
            {
                _color = value; pictureBoxRoom.BackColor = value; lbRoom.BackColor = value;
                panelContainer.BackColor = value;
            }
        }

      
        public int Id { get => _id; set => _id = value; }
        public int IdReceive { get => _idReceive; set => _idReceive = value; }
       
      
        public int IdBookRoom { get => _idBookRoom; set => _idBookRoom = value; }

        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;

        public class UpdateEventArgs : EventArgs
        {
            public int id { get; set; }
            public int idReceive { get; set; }
            public int idBookRoom { get; set; }
        }

        public void update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            args.id = Id;
            args.idReceive = IdReceive;
            args.idBookRoom = IdBookRoom;
            EventUpdateHandler.Invoke(this, args);
        }
        private void pictureBoxRoom_Click(object sender, System.EventArgs e)
        {
          
            update();
        }
      
    }
}