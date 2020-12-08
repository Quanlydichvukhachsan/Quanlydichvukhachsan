using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO.Receive
{
   public class ReceiveRoomDTO
    {
        public ReceiveRoomDTO(int idRoom, int idBookRoom)
        {
            IdRoom = idRoom;
            IdBookRoom = idBookRoom;
        }
        private List<string> listName = null;
        public ReceiveRoomDTO() { listName = new List<string>(); }

        public ReceiveRoomDTO(int idRoom, int idBookRoom, int id)
        {
            IdRoom = idRoom;
            IdBookRoom = idBookRoom;
            Id = id;
        }
        public ReceiveRoomDTO(DataRow row, DataTable data)
        {
            listName = InitNameColumn.init(data);
            Id = int.Parse(row[listName[0]].ToString());
            IdBookRoom = int.Parse(row[listName[1]].ToString());
            IdRoom = int.Parse(row[listName[2]].ToString());
           
        }
        public int IdRoom { get; set; }
        public int IdBookRoom { get; set; }
        public int Id { get; set; }

    }
}
