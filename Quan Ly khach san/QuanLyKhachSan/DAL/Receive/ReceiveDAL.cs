using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Receive;
using System.Data;
namespace DAL.Receive
{
    public class ReceiveDAL :IReposityDAL<ReceiveDTO>
    {
        private readonly static ReceiveDAL instance;
        public static ReceiveDAL Instance
        {
            get
            {
                if (instance == null) return new ReceiveDAL(); return instance;
            }
        }
        private List<ReceiveDTO> ListReceiveRoom;
        private List<ReceiveRoomDTO> ListReceive;
        public ReceiveDAL()
        {
            ListReceiveRoom = new List<ReceiveDTO>();
            ListReceive = new List<ReceiveRoomDTO>();
        }


        public bool DeleteById(string id)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("delete from ReceiveRoom where ID ="+id);
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool Insert(ReceiveDTO obj)
        {
           
            throw new NotImplementedException(); 
        }

        public bool InsertReceiveRoom(ReceiveRoomDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.InsertReceiveRoom @idBookRoom , @idRoom", new object[] { obj.IdBookRoom,obj.IdRoom });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public IEnumerable<ReceiveDTO> readAll()
        {

            throw new NotImplementedException();
        }
        public List<ReceiveDTO> ReadAllByDate(DateTime date)
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("USP_LoadReceiveRoomsByDate @date", new object[] {date });
            foreach (DataRow row in dataTable.Rows)
            {
                ReceiveDTO roomReceive = new ReceiveDTO(row, dataTable);
                ListReceiveRoom.Add(roomReceive);
            }
            return ListReceiveRoom;
        }

        public  bool UpdateById(ReceiveDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool UpdateReceive(ReceiveRoomDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_UpdateReceiveRoom @idBookRoom , @idRoom", new object[] { obj.IdBookRoom, obj.IdRoom });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
         
        }
        public List<ReceiveRoomDTO> ReadAllReceiveRoom()
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("select * from ReceiveRoom");
            foreach (DataRow row in dataTable.Rows)
            {
                ReceiveRoomDTO roomReceive = new ReceiveRoomDTO(row, dataTable);
                ListReceive.Add(roomReceive);
            }
            return ListReceive;
        }

    }
}
