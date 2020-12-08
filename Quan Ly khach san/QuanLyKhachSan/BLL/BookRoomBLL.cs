using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
<<<<<<< HEAD
   public class BookRoomBLL : IReposityBLL<BookRoomDTO>
=======
    public class BookRoomBLL : IReposityBLL<BookRoomDTO>
>>>>>>> developInsertCustomerAndBookRoom
    {
        private static readonly BookRoomBLL instance;
      private  List<BookRoomDTO> bookRoom = new List<BookRoomDTO>();

        public static BookRoomBLL Instance

        {
            get { if (instance == null) return new BookRoomBLL(); return BookRoomBLL.instance; }
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD

        public IEnumerable<BookRoomDTO> readAll()
        {
            return (List<BookRoomDTO>)BookRoomDAL.Instance.readAll();
=======
        public bool InsertBookRoom(BookRoomDTO obj, DateTime dateTime)
        {
            return BookRoomDAL.Instance.InsertBookRoom(obj, dateTime);
        }
        public IEnumerable<BookRoomDTO> readAll()
        {
            return BookRoomDAL.Instance.readAll();
>>>>>>> developInsertCustomerAndBookRoom
        }

        public bool UpdateById(int id, BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }
        public List<BookRoomByDateDTO> ReadBookRoomByDate(DateTime date)
        {
            return BookRoomByDateDAL.Instance.ReadBookRoomByDate(date);
        }
    }


}