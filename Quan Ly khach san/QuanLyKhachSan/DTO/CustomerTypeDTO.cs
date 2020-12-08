using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class CustomerTypeDTO
    {
        private readonly int iD_;
        private readonly string name_;

        List<string> listName = null;
        public CustomerTypeDTO() { }

        public CustomerTypeDTO(DataRow row, DataTable data)
        {
            listName = InitNameColumn.init(data);
            this.iD_ = int.Parse(row[listName[0]].ToString());
            this.name_ = row[listName[1]].ToString();
        }

        public CustomerTypeDTO(int iD_, string name_)
        {
            this.iD_ = iD_;
            this.name_ = name_;
        }

        public int ID_ => iD_;

        public string Name_ => name_;
    }
}
