using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class RoomType
    {
        private  int _price;
        private  int _limitPerson;
        private  string _nameRoomType; 
        private  int _idRoomType;
        private DateTime _dayUpdate;
        private string _notes;
        private List<string> listName = null;
        public int Price { get => _price; set => _price = value; }

        public int LimitPerson { get => _limitPerson; set => _limitPerson = value; }

        public string NameRoomType  { get => _nameRoomType; set => _nameRoomType = value; }

    public int IdRoomType => _idRoomType;

        public DateTime DayUpdate { get => _dayUpdate; set => _dayUpdate = value; }
        public string Notes { get => _notes; set => _notes = value; }

        public RoomType(DataRow row,DataTable data)
        {
            listName = InitNameColumn.init(data);
             _idRoomType =  int.Parse(row[listName[0]].ToString());
             _nameRoomType = row[listName[1]].ToString();
            _price = int.Parse(row[listName[2]].ToString());
            _limitPerson = int.Parse(row[listName[3]].ToString());
                          
        }

        public RoomType(int price, int limitPerson, string nameRoomType, int idRoomType, DateTime dayUpdate, string notes)
        {
            _price = price;
            _limitPerson = limitPerson;
            _nameRoomType = nameRoomType;
            _idRoomType = idRoomType;
            _dayUpdate = dayUpdate;
            _notes = notes;
        }
    }
}
