using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class RoomDAL : IReposityDAL<RoomDTO>
    {
        private readonly static RoomDAL instance ;
        public  List<RoomDTO> ListRoom =null;
        public static RoomDAL Instance { get { if (instance == null) return new RoomDAL(); return RoomDAL.instance; } } 

        public RoomDAL() { ListRoom = new List<RoomDTO>(); }
        public bool DeleteById(RoomDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RoomDTO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomDTO> readAll()
        {
            DataTable dataTable =  DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadFullRoom");
            foreach(DataRow row in dataTable.Rows)
            {
               RoomDTO room = new RoomDTO(row);
                ListRoom.Add(room);
            }
                return ListRoom;

        }

        public bool UpdateById(RoomDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
