using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BookRoomDAL : IReposityDAL<BookRoomDTO>
    {
        private readonly static BookRoomDAL instance;

        public static BookRoomDAL Instance { get { if (instance == null) return new BookRoomDAL(); return instance; } }
        public List<BookRoomDTO> listBookRoom = null;
        public List<CustomerDTO> listCutomer = null;
        public List<RoomType> listRoomType = null;

        public BookRoomDAL()
        {
            listBookRoom = new List<BookRoomDTO>();
            listCutomer = new List<CustomerDTO>();
            listRoomType = new List<RoomType>();
        }

        public bool DeleteById(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }
        public bool Insert(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }
        public bool InsertBookRoom(BookRoomDTO obj, DateTime time)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("USP_InsertBookRoom @idCustomer , @idRoomType , @datecheckin , @datecheckout , @datebookroom",
                                             new object[] { obj.IDCustomer_, obj.IDRoomType_, obj.DateCheckIn_, obj.DateCheckOut_, time });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }        
        }

        public IEnumerable<BookRoomDTO> readAll()
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("USP_LoadFullCustomer");
            foreach (DataRow row in dataTable.Rows)
            {
                BookRoomDTO Room = new BookRoomDTO(row, dataTable);
                bookRoom.Add(Room);
            }
            return bookRoom;
        }

        public bool UpdateById(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
