using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class BookRoomDTO
    {
        private readonly int iD_;
        private readonly int iDCustomer_;
        private readonly int iDRoomType_;
        private readonly DateTime dateBookRoom_;
        private readonly DateTime dateCheckIn_;
        private readonly DateTime dateCheckOut_;
        List<string> listName = null;

        public BookRoomDTO() { }
        public BookRoomDTO(DataRow row, DataTable data)
        {
            listName = InitNameColumn.init(data);
            this.iD_ = int.Parse(row[listName[0]].ToString());
            this.iDCustomer_ = int.Parse(row[listName[1]].ToString());
            this.iDRoomType_ = int.Parse(row[listName[2]].ToString());
            this.dateBookRoom_ = DateTime.Parse(row[listName[3]].ToString());
            this.dateCheckIn_ = DateTime.Parse(row[listName[4]].ToString());
            this.dateCheckOut_ = DateTime.Parse(row[listName[5]].ToString());
        }

        public BookRoomDTO(int iD_, int iDCustomer_, int iDRoomType_, DateTime dateBookRoom_, DateTime dateCheckIn_, DateTime dateCheckOut_)
        {
            this.iD_ = iD_;
            this.iDCustomer_ = iDCustomer_;
            this.iDRoomType_ = iDRoomType_;
            this.dateBookRoom_ = dateBookRoom_;
            this.dateCheckIn_ = dateCheckIn_;
            this.dateCheckOut_ = dateCheckOut_;
        }

        public int ID_ => iD_;

        public int IDCustomer_ => iDCustomer_;

        public int IDRoomType_ => iDRoomType_;

        public DateTime DateBookRoom_ => dateBookRoom_;

        public DateTime DateCheckIn_ => dateCheckIn_;

        public DateTime DateCheckOut_ => dateCheckOut_;
    }
}
