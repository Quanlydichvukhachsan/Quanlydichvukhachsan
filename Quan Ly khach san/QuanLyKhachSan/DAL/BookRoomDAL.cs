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

       
        public bool Insert(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookRoomDTO> readAll()
        {
            throw new NotImplementedException();
        }

        public bool UpdateById(BookRoomDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
