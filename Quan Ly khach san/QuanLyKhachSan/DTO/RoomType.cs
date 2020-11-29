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
        private readonly int _price;
        private readonly int _limitPerson;
        private readonly string _nameRoomType; 
        private readonly int _idRoomType;
        private List<string> listName = null;
        public int Price => _price;

        public int LimitPerson => _limitPerson;

        public string NameRoomType => _nameRoomType;

        public int IdRoomType => _idRoomType;

           public RoomType(DataRow row,DataTable data)
        {
            listName = InitNameColumn.init(data);
             _idRoomType =  int.Parse(row[listName[0]].ToString());
             _nameRoomType = row[listName[1]].ToString();
            _price = int.Parse(row[listName[2]].ToString());
            _limitPerson = int.Parse(row[listName[3]].ToString());
                          
        }

    }
}
