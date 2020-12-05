using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO.Receive
{
    public class ReceiveDTO
    {

        private List<string> listName = null;
        public int IdBookRoom { get; set; }
        public string NameCustomer { get; set; }
        public string CMND { get; set; }
        public string NameRoom { get; set; }

        public DateTime NgayNhan { get; set; }
        public DateTime Ngaytra { get; set; }

        public ReceiveDTO() { listName = new List<string>(); }
        public ReceiveDTO(int idBookRoom, string nameCustomer, string cMND, string nameRoom, DateTime ngayNhan, DateTime ngaytra)
        {
            IdBookRoom = idBookRoom;
            NameCustomer = nameCustomer;
            CMND = cMND;
            NameRoom = nameRoom;
            NgayNhan = ngayNhan;
            Ngaytra = ngaytra;
        }

        public ReceiveDTO(DataRow row, DataTable data)
        {

            listName = InitNameColumn.init(data);
            IdBookRoom = int.Parse(row[listName[0]].ToString());
            NameCustomer = row[listName[1]].ToString();
            CMND =row[listName[2]].ToString();
            NameRoom = row[listName[3]].ToString();
            NgayNhan = DateTime.Parse(row[listName[4]].ToString());
            Ngaytra = DateTime.Parse(row[listName[5]].ToString());
        }







    }
}
