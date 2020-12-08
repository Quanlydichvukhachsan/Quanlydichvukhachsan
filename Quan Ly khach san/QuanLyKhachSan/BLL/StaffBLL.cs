using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
   public class StaffBLL :IReposityBLL<StaffDTO>
    {
        private readonly static StaffBLL instance;
        public static StaffBLL Instance { get { if (instance == null) return new StaffBLL(); return instance; } }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(StaffDTO obj)
        {
            return StaffDAL.Instance.Insert(obj);
        }

        public IEnumerable<StaffDTO> readAll()
        {
            return StaffDAL.Instance.readAll();
        }

        public bool UpdateById(int id, StaffDTO obj)
        {
            return StaffDAL.Instance.UpdateById(obj);
        }
    }
}
