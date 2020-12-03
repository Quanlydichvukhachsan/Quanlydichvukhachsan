using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
   public class BookRoomBLL : IReposityBLL<BookRoomBLL>
    {
        private static readonly BookRoomBLL instance;

        public static BookRoomBLL Instance

        {
            get { if (instance == null) return new BookRoomBLL(); return BookRoomBLL.instance; }
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BookRoomBLL obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookRoomBLL> readAll()
        {
            throw new NotImplementedException();
        }

        public bool UpdateById(int id, BookRoomBLL obj)
        {
            throw new NotImplementedException();
        }
        public List<BookRoomByDateDTO> ReadBookRoomByDate(DateTime date)
        {
            return BookRoomByDateDAL.Instance.ReadBookRoomByDate(date);
        }

    }
}
