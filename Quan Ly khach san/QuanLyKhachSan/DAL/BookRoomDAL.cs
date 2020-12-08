using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
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

        public bool CancelBookRoom(int idRoom)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("USP_DeleteBookRoom @id",
                                             new object[] { idRoom });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<BookRoomDTO> readAll()
        {
            DataTable dataTable = DataProvider.Instance.ExcuteDataReader("select * from BookRoom");
            foreach (DataRow row in dataTable.Rows)
            {
                BookRoomDTO bookRoom = new BookRoomDTO(row, dataTable);
                listBookRoom.Add(bookRoom);
            }
            return listBookRoom;
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

        public bool UpdateById(BookRoomDTO obj)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery(" USP_UpdateBookRoom @id , @idRoomType , @dateCheckIn , @datecheckOut",
                                             new object[] { obj.ID_,  obj.IDRoomType_, obj.DateCheckIn_, obj.DateCheckOut_,});
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
