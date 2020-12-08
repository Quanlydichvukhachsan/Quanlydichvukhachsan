using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bill;
using DTO.Bill;
namespace BLL.Bill
{
    public class BillRoomPriceBLL
    {
        private readonly static BillRoomPriceBLL instance;
        public static BillRoomPriceBLL Instance { get { if (instance == null) return new BillRoomPriceBLL(); return instance; } }

        public int CheckExistBillRoom(int idRoom)
        {
            return BillRoomPriceDAL.Instance.CheckExistBillRoom(idRoom);
        }
        public int InsertBillRoomPrice(int idReceiveRoom, string staffSetUp)
        {
            return BillRoomPriceDAL.Instance.InsertBillRoomPrice(idReceiveRoom, staffSetUp);
        }
        public IEnumerable<BillRoomPrice> readServiceByIdRoom(DateTime dateCheckIn, int idRoom)
        {
            return BillRoomPriceDAL.Instance.readServiceByIdRoom(dateCheckIn, idRoom);
        }

        public bool UpdateBillRoomPrice(int idBill)
        {
            return BillRoomPriceDAL.Instance.UpdateBillRoomPrice(idBill);
        }
    }
}
