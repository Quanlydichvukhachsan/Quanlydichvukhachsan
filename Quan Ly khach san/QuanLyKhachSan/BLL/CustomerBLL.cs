using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
   public class CustomerBLL : IReposityBLL<CustomerDTO>
    {
        private readonly static CustomerBLL instance;

        public static CustomerBLL Instance
        {
            get { if (instance == null) return new CustomerBLL(); return instance; }
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<CustomerTypeDTO> LoadCustomerType()
        {
            return CustomerDAL.Instance.LoadFullCustomerType();
        }

        public bool Insert(CustomerDTO obj)
        {
            //HandlerError.CheckRequire(obj.Name_, "Họ và tên không hợp lệ");
            //HandlerError.checkminlength(obj.Name_, 9, "Tên phải lớn hơn 10 kí tự");
            //string iDCard = mtbInsertIdCard.Text;
         
            return CustomerDAL.Instance.Insert(obj);

        }

        public IEnumerable<CustomerDTO> readAll()
        {
            return CustomerDAL.Instance.readAll();
        }

        public bool UpdateById(int id, CustomerDTO obj)
        {
            throw new NotImplementedException();
        }
        public bool Update(CustomerDTO obj)
        {
            return CustomerDAL.Instance.Update(obj);
        }
    }
}
