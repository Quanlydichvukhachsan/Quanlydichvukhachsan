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
        private List<RoomDTO> ListRoom = null;
        private BindingSource dataSource = new BindingSource();
        public frmQLPhong()
        {
            InitializeComponent();
            ListRoom = new List<RoomDTO>();
            ListIdRoom = new List<int>();
  
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
    
            LoadRoom();
            LoadStatusRoom();
            LoadRoomType();
            LoadIdRoom();
          //  AddBinding();
       
        }
        private void LoadRoom()
        {
            int i = 0;
            dtgvDanhsachPhongQLP.Rows.Clear();
            ListRoom = new List<RoomDTO>(RoomBLL.Instance.readAll());
             foreach (RoomDTO items in ListRoom )
             {

                dtgvDanhsachPhongQLP.Rows.Add();
                dtgvDanhsachPhongQLP.Rows[i].Cells[0].Value = items.Id;
                ListIdRoom.Add(items.Id);
                dtgvDanhsachPhongQLP.Rows[i].Cells[1].Value = items.NameRoom;
                dtgvDanhsachPhongQLP.Rows[i].Cells[2].Value = items.NameRoomType;
                dtgvDanhsachPhongQLP.Rows[i].Cells[3].Value = items.Price;
                dtgvDanhsachPhongQLP.Rows[i].Cells[4].Value = items.LimitPerson;
                dtgvDanhsachPhongQLP.Rows[i].Cells[5].Value = items.NameStatusRoom;
                i++;
             }
                   
         
        }
        private void LoadStatusRoom()
        {
            cbStatusRoom.DataSource = RoomBLL.Instance.LoadStatusRoom();
            cbStatusRoom.DisplayMember = "NameStatusRoom";
        }
        private void LoadRoomType()
        {
            cbbLoaiPhongQLP.DataSource = RoomBLL.Instance.LoadRoomType();
            cbbLoaiPhongQLP.DisplayMember = "NameRoomType";
        }
        private void LoadIdRoom()
        {
            cbbMaPhongQLP.DataSource = ListIdRoom;
           
            
        }
        private void AddBinding()
        {
                       /*txtSoNguoiToiDa.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Limitperson"));
            txtGiaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "Price"));
            cbbLoaiPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameRoomType"));
            cbStatusRoom.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "nameStatusRoom"));
             cbbMaPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP.DataSource, "ID"));*/



        }

        private void dtgvDanhsachPhongQLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtTenPhongQLP.DataBindings.Add(new Binding("Text", dtgvDanhsachPhongQLP[1,e.RowIndex],"",false,DataSourceUpdateMode.OnPropertyChanged));

        }
    }
}
