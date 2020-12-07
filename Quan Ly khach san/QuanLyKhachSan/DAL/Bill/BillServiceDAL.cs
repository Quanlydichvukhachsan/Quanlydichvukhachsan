using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO.BillService;

namespace DAL.Bill
{
    public class BillServiceDAL : IReposityDAL<BillServiceDTO>
    {
        private readonly static BillServiceDAL instance;
        public static BillServiceDAL Instance { get { if (instance == null) return new BillServiceDAL(); return instance; } }
        private List<BillServiceDTO> ListBillService = null;

        public BillServiceDAL() { ListBillService = new List<BillServiceDTO>(); }
        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BillServiceDTO obj)
        {
            throw new NotImplementedException();
        }
        public bool InsertBillService(int idBill, int id,int idService , int count)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_InsertBillDetails @idBill , @idService , @count", new object[] { idBill, id, idService ,count });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool UpdateBillService(int idBill, int id, int idService, int count)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("dbo.USP_UpdateBillDetails @idBill , @idService , @_count", new object[] { idBill, id, idService, count });
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public IEnumerable<BillServiceDTO> readAll()
        {

            throw new NotImplementedException();
        }
        public IEnumerable<BillServiceDTO> readServiceByIdRoom(int id )
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("dbo.USP_ShowBill @idRoom",new object[] { id });
            foreach (DataRow row in dataTable.Rows)
            {
                BillServiceDTO billService = new BillServiceDTO(row, dataTable);
                ListBillService.Add(billService);
            }
            return ListBillService;
        }
        public bool UpdateById(BillServiceDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
