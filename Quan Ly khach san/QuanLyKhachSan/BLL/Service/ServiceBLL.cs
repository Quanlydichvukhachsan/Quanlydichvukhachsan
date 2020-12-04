using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Service;
using DAL.Service;
namespace BLL.Service
{
    public class ServiceBLL : IReposityBLL<ServiceDTO>
    {
        private readonly static ServiceBLL instance;
        public static ServiceBLL Instance { get { if (instance == null) return new ServiceBLL(); return instance; } }
        public bool DeleteById(string id)
        {
            return ServiceDAL.Instance.DeleteById(id);
        }

        public bool Insert(ServiceDTO obj)
        {
            return ServiceDAL.Instance.Insert(obj);
        }

        public bool InsertType(ServiceTypeDTO obj)
        {
            return ServiceDAL.Instance.InsertServiceType(obj);
        }
        public  IEnumerable<ServiceTypeDTO> ReadAllServiceType()
        {
            return (List<ServiceTypeDTO>)ServiceDAL.Instance.readAllServiceType();
        }

        public IEnumerable<ServiceDTO> readAll()
        {
           return (List<ServiceDTO>)ServiceDAL.Instance.readAll();
        }

        public bool UpdateById(int id, ServiceDTO obj)
        {
            return ServiceDAL.Instance.UpdateById(obj);
        }

        public bool UpdateById(int id, ServiceTypeDTO obj)
        {
            return ServiceDAL.Instance.UpdateServiceTypeById(obj);
        }
    }
}
