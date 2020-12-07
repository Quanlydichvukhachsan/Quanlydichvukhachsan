using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO.Bill
{
  public  class BillRoomPrice
    {
      
        public string NameRoom { get; set; }
        public int Price { get; set; }

        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }

        public int TotalPrice { get; set; }
        public int Surcharge { get; set; }
        private List<string> listName = null;
        public BillRoomPrice(string nameRoom, int price, DateTime ngayNhan, DateTime ngayTra, int totalPrice, int surcharge)
        {
            NameRoom = nameRoom;
            Price = price;
            NgayNhan = ngayNhan;
            NgayTra = ngayTra;
            TotalPrice = totalPrice;
            Surcharge = surcharge;
        }
        public BillRoomPrice() { listName = new List<string>(); }

        public BillRoomPrice(DataRow row, DataTable data)
        {

             listName = InitNameColumn.init(data);

            NameRoom = row[listName[0]].ToString();
            Price = int.Parse(row[listName[1]].ToString());
             NgayNhan = DateTime.Parse(row[listName[2]].ToString());
             NgayTra = DateTime.Parse(row[listName[3]].ToString());
              TotalPrice = int.Parse(row[listName[4]].ToString());
             Surcharge = int.Parse(row[listName[5]].ToString());

        }
    }
}
