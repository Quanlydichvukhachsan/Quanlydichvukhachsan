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
        private  int iD_;
        private  int iDCustomer_;
        private  int iDRoomType_;
        private  DateTime dateBookRoom_;
        private  DateTime dateCheckIn_;
        private  DateTime dateCheckOut_;
        List<string> listName = null;

        public BookRoomDTO() { }
        public BookRoomDTO(DataRow row, DataTable data)
        {
            listName = InitNameColumn.init(data);
            this.ID_ = int.Parse(row[listName[0]].ToString());
            this.IDCustomer_ = int.Parse(row[listName[1]].ToString());
            this.IDRoomType_ = int.Parse(row[listName[2]].ToString());
            this.DateBookRoom_ = DateTime.Parse(row[listName[3]].ToString());
            this.DateCheckIn_ = DateTime.Parse(row[listName[4]].ToString());
            this.DateCheckOut_ = DateTime.Parse(row[listName[5]].ToString());
        }

        public BookRoomDTO( int iDCustomer_, int iDRoomType_, DateTime dateBookRoom_, DateTime dateCheckIn_, DateTime dateCheckOut_)
        {

            this.IDCustomer_ = iDCustomer_;
            this.IDRoomType_ = iDRoomType_;
            this.DateBookRoom_ = dateBookRoom_;
            this.DateCheckIn_ = dateCheckIn_;
            this.DateCheckOut_ = dateCheckOut_;
        }

        public int ID_ { get => iD_; set => iD_ = value; }
        public int IDCustomer_ { get => iDCustomer_; set => iDCustomer_ = value; }
        public int IDRoomType_ { get => iDRoomType_; set => iDRoomType_ = value; }
        public DateTime DateBookRoom_ { get => dateBookRoom_; set => dateBookRoom_ = value; }
        public DateTime DateCheckIn_ { get => dateCheckIn_; set => dateCheckIn_ = value; }
        public DateTime DateCheckOut_ { get => dateCheckOut_; set => dateCheckOut_ = value; }

        //public int ID_ => iD_;

        //public int IDCustomer_ => iDCustomer_;

        //public int IDRoomType_ => iDRoomType_;

        //public DateTime DateBookRoom_ => dateBookRoom_;

        //public DateTime DateCheckIn_ => dateCheckIn_;

        //public DateTime DateCheckOut_ => dateCheckOut_;
    }
}
