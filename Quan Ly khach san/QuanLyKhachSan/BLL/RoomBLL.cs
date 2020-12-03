using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class RoomBLL : IReposityBLL<RoomDTO>
    {  
        private readonly static RoomBLL instance ;
       public static RoomBLL Instance { get { if (instance == null) return new RoomBLL(); return instance; } } 

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RoomDTO obj)
        {
          return  RoomDAL.Instance.Insert(obj);
        }
        public bool UpdateRoomType(RoomType obj)
        {
            return RoomDAL.Instance.UpdateRoomType(obj);
        }
        public bool InsertRoomTypeUpdateDay(RoomType obj)
        {
            return RoomDAL.Instance.InsertUpdateRoomTypeDay(obj);
        }

        public IEnumerable<RoomDTO> readAll()
        {
           return RoomDAL.Instance.readAll();
        }
      
        public IEnumerable<StatusRoom> LoadStatusRoom()
        {
            return RoomDAL.Instance.LoadFullSatusRoom();
        }
         public IEnumerable<RoomType> LoadRoomType()
        {
            return RoomDAL.Instance.LoadFullRoomType();
        }


        public bool UpdateById(int id, RoomDTO obj)
        {
            return RoomDAL.Instance.UpdateById(obj);
        }
    }
}
