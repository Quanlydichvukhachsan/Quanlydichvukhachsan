﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO.Bill;
namespace DAL.Bill
{
   public class BillRoomPriceDAL
    {
        private readonly static BillRoomPriceDAL instance;
        public static BillRoomPriceDAL Instance { get { if (instance == null) return new BillRoomPriceDAL(); return instance; } }
        private List<BillRoomPrice> ListBillRoomPrice = null;

        public BillRoomPriceDAL() { ListBillRoomPrice = new List<BillRoomPrice>(); }
        public IEnumerable<BillRoomPrice> readServiceByIdRoom(DateTime dateCheckIn,int idRoom)
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("dbo.USP_ShowBillRoom @getToday , @idRoom", new object[] { dateCheckIn ,idRoom });
            foreach (DataRow row in dataTable.Rows)
            {
                BillRoomPrice billRoomService = new BillRoomPrice(row, dataTable);
                ListBillRoomPrice.Add(billRoomService);
            }
            return ListBillRoomPrice;
        }

        public bool UpdateBillRoomPrice(int idBill)
        {
            try
            {
             
               return DataProvider.Instance.ExcuteNonQuery("dbo.USP_UpdateBill_RoomPrice @idBill", new object[] { idBill });
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public int InsertBillRoomPrice(int idReceiveRoom, string staffSetUp)
        {
            try
            {

                return DataProvider.Instance.ExcuteScalar("dbo.USP_InsertBill @idReceiveRoom , @staffSetUp", new object[] { idReceiveRoom, staffSetUp });
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public int CheckExistBillRoom(int idRoom)
        {
            //bool check = false;
           return  DataProvider.Instance.ExcuteScalar("dbo.USP_IsExistBillOfRoom @idRoom", new object[] { idRoom });
           /* if( dataTable.Rows.Count > 0)
            {
                check = true; 
            }

            return check;*/
         
        }

    }
}
