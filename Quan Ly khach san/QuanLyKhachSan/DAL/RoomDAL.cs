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
        public List<RoomDTO> ListRoomPerson = null;
        public  List<RoomDTO> ListRoom =null;
        public List<StatusRoom> ListStatusRoom = null;
        public List<RoomType> ListRoomType = null;
        public static RoomDAL Instance { get { if (instance == null) return new RoomDAL(); return instance; } } 

        public RoomDAL() {
            ListRoomPerson = new List<RoomDTO>();
            ListRoom = new List<RoomDTO>();
            ListStatusRoom = new List<StatusRoom>();
            ListRoomType = new List<RoomType>();
        }
        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RoomDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_InsertRoom @nameRoom , @idRoomType , @idStatusRoom", new object[] {obj.NameRoom,obj.IdRoomType,obj.IdStatusRoom });
                return true;
            }catch(Exception err)
            {
                throw err;
            }

        }
        
        public bool InsertUpdateRoomTypeDay(RoomType obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("USP_UpdateRoomTypeByDate @name , @price , @limitPerson , @dayUpdate , @note , @idRoomType",
                                                    new object[] { obj.NameRoomType, obj.Price, obj.LimitPerson,obj.DayUpdate,obj.Notes, obj.IdRoomType });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }

        }
        public bool UpdateRoomType(RoomType obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("USP_UpdateRoomType @id , @name , @price , @limitPerson",
                                                    new object[] { obj.IdRoomType, obj.NameRoomType, obj.Price, obj.LimitPerson});
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public IEnumerable<RoomDTO> readAll()
        {
            DataTable dataTable =  DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadFullRoom");
            foreach(DataRow row in dataTable.Rows)
            {
               RoomDTO room = new RoomDTO(row,dataTable);
                ListRoom.Add(room);
            }
                return ListRoom;

        }
       
        public IEnumerable<StatusRoom> LoadFullSatusRoom()
        {
            DataTable dataTable =  DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadFullStatusRoom");
            foreach(DataRow row in dataTable.Rows)
            {
               StatusRoom room = new StatusRoom(row,dataTable);
                ListStatusRoom.Add(room);
            }
                return ListStatusRoom;

        }
             public IEnumerable<RoomType> LoadFullRoomType()
         {
            DataTable dataTable =  DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadFullRoomType");
            foreach(DataRow row in dataTable.Rows)
            {
               RoomType room = new RoomType(row,dataTable);
                ListRoomType.Add(room);
            }
                return ListRoomType;

        }



        public bool UpdateById(RoomDTO obj)
        {

            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_UpdateRoom @id , @nameRoom , @idRoomType , @idStatusRoom",
                                                      new object[] { obj.Id, obj.NameRoom, obj.IdRoomType,obj.IdStatusRoom });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
