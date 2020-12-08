using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

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
        public bool DeleteById(CustomerDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CustomerDTO obj)
        {
            bool result = DataProvider.Instance.ExcuteNonQuery("USP_InsertCustomer @customerName , @idCustomerType , @idCard , @address , @dateOfBirth , @phoneNumber , @sex , @nationality",
                                                             new object[] { obj.Name_, obj.IDCustomerType_, obj.IDCard_, obj.Address_, obj.DateOfBirth_, obj.PhoneNumber_, obj.Sex1, obj.Nationality_ })  ;
            return result;
        }
        public IEnumerable<CustomerTypeDTO> LoadFullCustomerType()
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("USP_LoadFullCustomerType");
            foreach (DataRow row in dataTable.Rows)
            {
                CustomerTypeDTO customer = new CustomerTypeDTO(row, dataTable);
                listCustomerType.Add(customer);
            }
            return listCustomerType;
        }
       // public IEnumerable<CustomerDTO> LoadFullRoom()

        public IEnumerable<CustomerDTO> readAll()
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("USP_LoadFullCustomer");
            foreach (DataRow row in dataTable.Rows)
            {
                CustomerDTO customer = new CustomerDTO(row, dataTable);
                listCustomer.Add(customer);
            }
            return listCustomer;
        }

        public bool UpdateById(CustomerDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(CustomerDTO obj)
        {
            try
            {
                bool result = DataProvider.Instance.ExcuteNonQuery("USP_UpdateCustomer_ @id , @name , @idCard , @idCustomerType , @phoneNumber , @dateOfBirth , @address , @sex , @nationality",
                                             new object[] { obj.ID_, obj.Name_, obj.IDCard_ ,obj.IDCustomerType_, obj.PhoneNumber_, obj.DateOfBirth_,obj.Address_,  obj.Sex1, obj.Nationality_});
                return true;
            }
            catch(Exception err)
            {
                throw err;
            }
        }
    }
}
