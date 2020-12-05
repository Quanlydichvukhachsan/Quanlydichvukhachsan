using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
   public class CustomerDAL : IReposityDAL<CustomerDTO>
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
        public bool DeleteById(string id)
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
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("USP_LoadFullCustomer");
            foreach (DataRow row in dataTable.Rows)
            {
                CustomerDTO room = new CustomerDTO(row, dataTable);
                listCustomer.Add(room);
            }
            return listCustomer;
        }

        public bool UpdateById(CustomerDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
