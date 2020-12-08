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
    public partial class ShowBookRoom : Form
    {
        public ShowBookRoom(List<BookRoomDTO> listBookRoom)
        {
            InitializeComponent();
            ListBookRoom = listBookRoom;
        }
        private DateTime date;
        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string name { get; set; }
            public DateTime Date { get; set; }
        }

        public void Update()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            args.Date = date;
            EventUpdateHandler.Invoke(this, args);
        }
        private void ShowBookRoom_Load(object sender, EventArgs e)
        {
            dtgShowBookRoom.DataSource = ListBookRoom;
        }
        public List<BookRoomDTO> ListBookRoom { get; set; }

        private void dtgShowBookRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             date =  DateTime.Parse(dtgShowBookRoom[3, e.RowIndex].FormattedValue.ToString());
            Update();
        }
    }
}
