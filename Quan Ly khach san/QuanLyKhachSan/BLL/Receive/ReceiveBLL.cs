using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Receive;
using DAL.Receive;
using DTO;
namespace BLL.Receive
{
    public class ReceiveBLL : IReposityBLL<ReceiveRoomDTO>
    {
        private readonly static ReceiveBLL instance;
        public static ReceiveBLL Instance
        {
            get
            {
                if (instance == null) return new ReceiveBLL(); return instance;
            }
        }
        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ReceiveRoomDTO obj)
        {
            return ReceiveDAL.Instance.InsertReceiveRoom(obj); 
        }

        public IEnumerable<ReceiveRoomDTO> readAll()
        {
            throw new NotImplementedException();
        }
        public List<ReceiveDTO> ReadAllReceiveRoom(DateTime date)
        {
            return ReceiveDAL.Instance.ReadAllByDate(date);
        }

        public bool UpdateById(int id, ReceiveRoomDTO obj)
        {
            throw new NotImplementedException();
        }
     
    }
}
