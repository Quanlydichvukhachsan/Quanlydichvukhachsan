using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    class CustomerDAL : IReposityDAL<CustomerDTO>
    {
        private readonly static CustomerDAL instance;
        List<CustomerDTO> listCustomer = null;
        List<CustomerTypeDTO> listCustomerType = null;


        public static CustomerDAL Instance { get { if (instance == null) return new CustomerDAL(); return instance; } }

        public CustomerDAL()
        {
            listCustomer = new List<CustomerDTO>();
            listCustomerType = new List<CustomerTypeDTO>();
        }
        public bool DeleteById(CustomerDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CustomerDTO obj)
        {
            bool data = DataProvider.Instance.ExcuteNonQuery("USP_InsertCustomer @customerName , @idCustomerType, @idCard, @address, @dateOfBirth, @phoneNumber, @sex, @nationality");
            return data;
        }

        public IEnumerable<CustomerDTO> readAll()
        {
            throw new NotImplementedException();
        }

        public bool UpdateById(CustomerDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
