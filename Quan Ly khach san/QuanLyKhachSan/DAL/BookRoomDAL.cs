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
        private static readonly BookRoomDAL instance;

        public static BookRoomDAL Instance

        {
            get { if (instance == null) return new BookRoomDAL(); return BookRoomDAL.instance; }
        }
        List<BookRoomDTO> listBookroomDTOs;
        public BookRoomDAL()
        {
            listBookroomDTOs = new List<BookRoomDTO>();
        }
      
        public bool DeleteById(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookRoomDTO> readAll()
        {
            throw new NotImplementedException();
        }

        public List<BookRoomDTO> ReadBookRoomByDate(DateTime date)
        {
            
             DataTable dataTable = DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadBookRoomsByDate @date", new object[] { date });
            foreach (DataRow row in dataTable.Rows)
            {
                BookRoomDTO room = new BookRoomDTO(row,dataTable);
                listBookroomDTOs.Add(room);
            }
            return listBookroomDTOs;

        }
        public bool UpdateById(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
