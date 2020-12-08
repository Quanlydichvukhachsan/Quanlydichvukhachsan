using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bill;
using DTO.BillService;
namespace BLL.Bill
{
    public class BillServiceBLL
    {
        private readonly static BillServiceBLL instance;
        public static BillServiceBLL Instance { get { if (instance == null) return new BillServiceBLL(); return instance; } }

        public bool InsertBillService(int idBill, int idService, int count)
        {
            return BillServiceDAL.Instance.InsertBillService(idBill, idService, count);
        }
        public bool UpdateBillService(int idBill,  int idService, int count)
        {
            return BillServiceDAL.Instance.UpdateBillService(idBill, idService, count);
        }
        public bool UpdateBillService_Price(int idBill)
        {
            return BillServiceDAL.Instance.UpdateBillService_Price(idBill);
        }
        public IEnumerable<BillServiceDTO> readServiceByIdRoom(int id)
        {
            return BillServiceDAL.Instance.readServiceByIdRoom(id);
        }
    }
}
