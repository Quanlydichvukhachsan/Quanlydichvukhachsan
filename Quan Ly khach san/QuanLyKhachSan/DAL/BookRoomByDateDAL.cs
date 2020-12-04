using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class BookRoomByDateDAL : IReposityDAL<BookRoomByDateDTO>
    {
        private static readonly BookRoomByDateDAL instance;

        public static BookRoomByDateDAL Instance

        {
            get { if (instance == null) return new BookRoomByDateDAL(); return BookRoomByDateDAL.instance; }
        }
        List<BookRoomByDateDTO> listBookroomDTOs;
        public BookRoomByDateDAL()
        {
            listBookroomDTOs = new List<BookRoomByDateDTO>();
        }
      
     

        public bool Insert(BookRoomByDateDTO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookRoomByDateDTO> readAll()
        {
            throw new NotImplementedException();
        }

        public List<BookRoomByDateDTO> ReadBookRoomByDate(DateTime date)
        {
            
             DataTable dataTable = DataProvider.Instance.ExcuteDataReader("dbo.USP_LoadBookRoomsByDate @date", new object[] { date });
            foreach (DataRow row in dataTable.Rows)
            {
                BookRoomByDateDTO room = new BookRoomByDateDTO(row,dataTable);
                listBookroomDTOs.Add(room);
            }
            return listBookroomDTOs;

        }
        public bool UpdateById(BookRoomByDateDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
