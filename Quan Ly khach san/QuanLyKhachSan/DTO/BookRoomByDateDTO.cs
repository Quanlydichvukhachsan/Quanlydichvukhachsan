using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace DTO
{
    public class BookRoomByDateDTO
    {
        private readonly int iDBookRom_;
        private readonly string name_;
        private readonly string cmnd_;
        private readonly string  roomType_;
        private readonly DateTime dateCheckIn_;
        private readonly DateTime dateChockOut_;
        private List<string> listName = null;
        public BookRoomByDateDTO()
        {
            listName = new List<string>();
        }
       
        public BookRoomByDateDTO(DataRow row, DataTable data)
        {
            listName = InitNameColumn.init(data);
            this.iDBookRom_ = int.Parse(row[listName[0]].ToString());
            this.name_ = (row[listName[1]].ToString());
            this.cmnd_ = (row[listName[2]].ToString());
            this.roomType_ = (row[listName[3]].ToString());
            this.dateCheckIn_ = DateTime.Parse(row[listName[4]].ToString());
            this.dateChockOut_ = DateTime.Parse(row[listName[5]].ToString());
        }

        public BookRoomByDateDTO(int iDBookRom_, string name_, string cmnd_, string roomType_, DateTime dateCheckIn_, DateTime dateChockOut_)
        {
            this.iDBookRom_ = iDBookRom_;
            this.name_ = name_;
            this.cmnd_ = cmnd_;
            this.roomType_ = roomType_;
            this.dateCheckIn_ = dateCheckIn_;
            this.dateChockOut_ = dateChockOut_;           
        }

        public int IDBookRom_ => iDBookRom_;

        public string Name_ => name_;

        public string Cmnd_ => cmnd_;

        public string RoomType_ => roomType_;

        public DateTime DateCheckIn_ => dateCheckIn_;

        public DateTime DateChockOut_ => dateChockOut_;

      
    }  
}
