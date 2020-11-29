using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
namespace DTO
{
    public class RoomDTO
    {
        private readonly int _id;
        private readonly string _nameRoom;
        private readonly int _idStatusRoom;
        private readonly int _idRoomType;
        private readonly int _price;
        private readonly int _limitPerson;
        private readonly string _nameStatusRoom;
        private readonly string _nameRoomType; 
        
        public int Id => _id; 

        public string  NameRoom => _nameRoom;

        public string NameRoomType => _nameRoomType;

        public int IdStatusRoom => _idStatusRoom;

        public int IdRoomType => _idRoomType;

        public int Price => _price;

        public int LimitPerson => _limitPerson;

        public string NameStatusRoom => _nameStatusRoom;

        private List<string> listName = null;  
        public RoomDTO() { }

        public RoomDTO(DataRow row,DataTable data)
        {

             listName = InitNameColumn.init(data);   

              _id = int.Parse(row[listName[0]].ToString());
            _nameRoom = row[listName[1]].ToString();
            _nameRoomType = row[listName[2]].ToString();
            _price = int.Parse(row[listName[3]].ToString());
            _limitPerson = int.Parse(row[listName[4]].ToString());
            _nameStatusRoom =  row[listName[5]].ToString();
            _idStatusRoom = int.Parse(row[listName[6]].ToString());
            _idRoomType =  int.Parse(row[listName[7]].ToString());
        }

        public RoomDTO(int id, string nameRoom,string nameRoomType ,int idStatusRoom, int idRoomType, int price, int limitPerson, string nameStatusRoom)
        {
            _id = id;
            _nameRoom = nameRoom;
            _nameRoomType = nameRoomType;
            _idStatusRoom = idStatusRoom;
            _idRoomType = idRoomType;
            _price = price;
            _limitPerson = limitPerson;
            _nameStatusRoom = nameStatusRoom;
        }

          }
}
