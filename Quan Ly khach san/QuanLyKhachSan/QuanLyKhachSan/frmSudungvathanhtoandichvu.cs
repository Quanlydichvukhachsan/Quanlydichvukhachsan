using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Service;
using DTO.Receive;
using BLL.Receive;
using DTO.Bill;
using BLL.Bill;
using BLL.Service;
using DTO.BillService;

using DTO;
using BLL;
namespace QuanLyKhachSan
{
    public partial class frmSudungvathanhtoandichvu : Form
    {
        private List<ServiceTypeDTO> listServieType = new List<ServiceTypeDTO>();
        private List<ServiceDTO> listService = new List<ServiceDTO>();
        private List<ReceiveRoomDTO> listReceive = new List<ReceiveRoomDTO>();
        private List<RoomControls> listRoomColor = new List<RoomControls>();
        private List<BillRoomPrice> listRoomBill = new List<BillRoomPrice>();
        private List<BillServiceDTO> listBillService = new List<BillServiceDTO>();
        private List<BookRoomDTO> listBookRoom = new List<BookRoomDTO>();
        private List<RoomDTO> listRoom = new List<RoomDTO>();
        private Color ColorRed =Color.FromArgb(255, 95,79);
        private Color ColorBlue = Color.FromArgb(1, 192, 253);
        private Color ColorGreen = Color.FromArgb(54, 202, 56);
        private Color ColorPink = Color.FromArgb(237, 131, 238);
        private Color ColorChoose = Color.FromArgb(48, 137, 86);
        private Color colorRoom;
        private int IdRoomReceive =0;
        private int IdRoom = 0,idService =0;
        private int IdBookRoom;
        public frmSudungvathanhtoandichvu()
        {
            InitializeComponent();
            listServieType = (List<ServiceTypeDTO>)ServiceBLL.Instance.ReadAllServiceType();
            listService = (List <ServiceDTO>)ServiceBLL.Instance.readAll();
            listReceive = ReceiveBLL.Instance.ReadAllReceive();
            listRoom = (List<RoomDTO>)RoomBLL.Instance.readAll();
            listBookRoom = (List<BookRoomDTO>)BookRoomBLL.Instance.readAll();

        }

        private void frmSudungvathanhtoandichvu_Load(object sender, EventArgs e)
        {
            LoadRoomFlowPanel();
          
        }
        private void LoadServiceType()
        {
            cbbRoomType.DataSource = listServieType;
            cbbRoomType.DisplayMember = "Name";
            cbbRoomType.ValueMember = "Name";
        }

        private void LoadService()
        {
            cbNameService.DataSource = listService;
            cbNameService.DisplayMember = "Name";
            cbNameService.ValueMember = "Name";
        }

        private void AddListRoomColorName()
        {
            if(listReceive.Count > 0)
            {
               
                foreach (ReceiveRoomDTO items in listReceive)
                {
                    var filter = listRoom.Where(p => p.Id == items.IdRoom).ToList();
                   
                    if (filter.Count > 0)
                    {

                        if (filter[0].IdStatusRoom == 1)
                        {
                            colorRoom = ColorRed;
                            
                            RoomControls room = new RoomControls();
                            room.EventUpdateHandler += Room_EventUpdateHandler;
                            room.NameRoom = filter[0].NameRoom;
                            room.ImgRoom = listImgRoom.Images[1];
                            room.ColorRoom = colorRoom;
                            room.Id = items.IdRoom;
                            room.IdReceive = items.Id;
                            room.IdBookRoom = items.IdBookRoom;
                            listRoomColor.Add(room);
                        }
                        else if (filter[0].IdStatusRoom == 2)
                        {
                            colorRoom = ColorPink;
                          
                            RoomControls room = new RoomControls();
                            room.EventUpdateHandler += Room_EventUpdateHandler;
                            room.NameRoom = filter[0].NameRoom;
                            room.ImgRoom = listImgRoom.Images[2];
                            room.ColorRoom = colorRoom;
                            room.Id = items.IdRoom;
                            room.IdReceive = items.Id;
                            room.IdBookRoom = items.IdBookRoom;
                            listRoomColor.Add(room);
                        }
                        else if (filter[0].IdStatusRoom == 3)
                        {
                            colorRoom = ColorBlue;
                            RoomControls room = new RoomControls();
                            room.EventUpdateHandler += Room_EventUpdateHandler;
                            room.NameRoom = filter[0].NameRoom;
                            room.ImgRoom = listImgRoom.Images[3];
                            room.ColorRoom = colorRoom;
                            room.Id = items.IdRoom;
                            room.IdReceive = items.Id;
                            room.IdBookRoom = items.IdBookRoom;
                            listRoomColor.Add(room);
                        }
                        else if (filter[0].IdStatusRoom == 4)
                        {
                            colorRoom = ColorGreen;
                            RoomControls room = new RoomControls();
                            room.EventUpdateHandler += Room_EventUpdateHandler;
                            room.NameRoom = filter[0].NameRoom;
                            room.ImgRoom = listImgRoom.Images[4];
                            room.ColorRoom = colorRoom;
                            room.Id = items.IdRoom;
                            room.IdReceive = items.Id;
                            room.IdBookRoom = items.IdBookRoom;
                            listRoomColor.Add(room);
                        }

                    }
                
                }
            }
            else
            {
                flowContainer.Controls.Clear();
            }
          
        
        }

        private void Room_EventUpdateHandler(object sender, RoomControls.UpdateEventArgs args)
        {
            IdRoom = args.id;
            IdRoomReceive = args.idReceive;
            IdBookRoom = args.idBookRoom;
            MessageBox.Show(IdRoom.ToString());
          
          
        }
        private void LoadRoomPrice()
        {
            var filter = listBookRoom.Find(p => p.ID_ == IdBookRoom);
            listRoomBill = (List<BillRoomPrice>)BillRoomPriceBLL.Instance.readServiceByIdRoom(filter.DateCheckIn_,IdRoom);
            int i = 0;
            dtgvBillRoomPrice.Rows.Clear();
            foreach (BillRoomPrice items in listRoomBill)
            {
                dtgvBillRoomPrice.Rows.Add();
                dtgvBillRoomPrice.Rows[i].Cells[0].Value = items.NameRoom;
                dtgvBillRoomPrice.Rows[i].Cells[1].Value = items.Price;
                dtgvBillRoomPrice.Rows[i].Cells[2].Value = items.NgayNhan;
                dtgvBillRoomPrice.Rows[i].Cells[3].Value = items.NgayTra;
                dtgvBillRoomPrice.Rows[i].Cells[4].Value = items.TotalPrice;
                dtgvBillRoomPrice.Rows[i].Cells[5].Value = items.Surcharge;
                int finalPrice = items.TotalPrice + items.Surcharge;
                dtgvBillRoomPrice.Rows[i].Cells[6].Value = finalPrice;
                i++;
            }
        }
        private void LoadBillServiceById()
        {
            listBillService = (List<BillServiceDTO>)BillServiceBLL.Instance.readServiceByIdRoom(IdRoom);
            int i = 0;
            dgvBillService.Rows.Clear();
            if(listBillService.Count >= 0)
            {
                foreach (BillServiceDTO items in listBillService)
                {
                    dgvBillService.Rows.Add();
                    dgvBillService.Rows[i].Cells[0].Value = i + 1;
                    dgvBillService.Rows[i].Cells[1].Value = items.nameService;
                    dgvBillService.Rows[i].Cells[2].Value = items.Price;
                    dgvBillService.Rows[i].Cells[3].Value = items.Count;
                    dgvBillService.Rows[i].Cells[4].Value = items.TotalPrice;
                    i++;
                }
            }
           
        }
     
        private void LoadDisPlay()
        {
            flowContainer.Controls.Clear();
            for(int i=0; i<listRoomColor.Count;i++)
            {
                flowContainer.Controls.Add(listRoomColor[i]);

            }
        }
        private void LoadRoomFlowPanel()
        {
            AddListRoomColorName();
            LoadDisPlay();


        }

        private void cbbRoomType_Click(object sender, EventArgs e)
        {
            LoadServiceType();
            //LoadService();
        }

        private void cbbRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            cbNameService.Items.Clear();
            var filter = from ServiceDTO service in listService
                         where service.NameServiceType.CompareTo(cbbRoomType.Text) == 0
                         select service;
            foreach (ServiceDTO services in filter)
            {
                cbNameService.Items.Add(services.Name);
                cbNameService.Text = services.Name;
            }
           
        }


        private void cbNameService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNameService.SelectedIndex != null)
            {
                var items = listService.Where(p => p.Name.CompareTo(cbNameService.Text) == 0).ToList();
                if (items.Count >= 0)
                {
                    txtGia.Text = items[0].Price.ToString();
                    idService = items[0].ID;
                   
                }
            }
        }

      

        private void btnAddServie_Click(object sender, EventArgs e)
        {
            if(IdRoomReceive !=0 || IdRoom !=0)
            {
                int id;
                id = BillRoomPriceBLL.Instance.CheckExistBillRoom(IdRoom);
                if (id!=0)
                {
                    // LoadRoomPrice();
                    // LoadBillServiceById();  int countService = Convert.ToInt32(updownSoluong.Value.ToString());
                    int countService = Convert.ToInt32(updownSoluong.Value.ToString());
                    if (countService == 0)
                    {
                        MessageBox.Show("Chọn số lượng dịch vụ");
                    }
                    else
                    {
                        BillServiceBLL.Instance.InsertBillService(id, idService, countService);
                       // BillServiceBLL.Instance.UpdateBillService_Price(id);
                        MessageBox.Show("Thêm dịch vụ thành công!");
                        LoadBillServiceById();
                    }
                }
                else
                {
                    
                    // BillRoomPriceBLL.Instance.UpdateBillRoomPrice(idBill);
                    // LoadRoomPrice();
                    int countService = Convert.ToInt32(updownSoluong.Value.ToString());

                    if (countService == 0)
                    {
                        MessageBox.Show("Chọn số lượng dịch vụ");
                    }
                    else
                    {
                        int idBill = BillRoomPriceBLL.Instance.InsertBillRoomPrice(IdRoomReceive, "admin");
                        BillServiceBLL.Instance.InsertBillService(idBill, idService, countService);
                        //BillServiceBLL.Instance.UpdateBillService_Price(idBill);
                        MessageBox.Show("Thêm dịch vụ thành công!");
                        LoadBillServiceById();
                    }
                    //   LoadRoomPrice();
                 
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng");
            }
            
        }
    }
}
