using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string NameRoom => _nameRoom;

        public string NameRoomType => _nameRoomType;

        public int IdStatusRoom => _idStatusRoom;

        public int IdRoomType => _idRoomType;

        public int Price => _price;

        public int LimitPerson => _limitPerson;

        public string NameStatusRoom => _nameStatusRoom;


        public RoomDTO() { }

        public RoomDTO(DataRow row)
        {
              _id = int.Parse(row["ID"].ToString());
            _nameRoom = row["Name"].ToString();
            _nameRoomType = row["nameRoomType"].ToString();
            _price = int.Parse(row["Price"].ToString());
            _limitPerson = int.Parse(row["LimitPerson"].ToString());
            _nameStatusRoom =  row["nameStatusRoom"].ToString();
            _idStatusRoom = int.Parse(row["IDRoomType"].ToString());
            _idRoomType =  int.Parse(row["IDStatusRoom"].ToString());
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
