using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class CustomersBLL : IReposityBLL<CustomerDTO>
    {
        private readonly static CustomersBLL instance;
        public static CustomersBLL Instance { get { if (instance == null) return new CustomersBLL(); return instance; } }
        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CustomerDTO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDTO> readAll()
        {
            return CustomerDAL.Instance.readAll();
        }

        public bool UpdateById(int id, CustomerDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
