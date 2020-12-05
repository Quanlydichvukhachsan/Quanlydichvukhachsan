using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Receive
{
   public class ReceiveRoomDTO
    {
        public ReceiveRoomDTO(int idRoom, int idBookRoom)
        {
            IdRoom = idRoom;
            IdBookRoom = idBookRoom;
        }
        public ReceiveRoomDTO() { }

        public int IdRoom { get; set; }
        public int IdBookRoom { get; set; }

    }
}
