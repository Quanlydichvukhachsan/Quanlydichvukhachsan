using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO.Service
{
  public  class ServiceTypeDTO
    {

        private List<string> listName = null;
        public int ID { get; set; }
        public string Name { get; set; }
     

        public ServiceTypeDTO() { listName = new List<string>(); }
        public ServiceTypeDTO(int iD, string name)
        {
            ID = iD;
            Name = name;
           
        }

        public ServiceTypeDTO(DataRow row, DataTable data)
        {

            listName = InitNameColumn.init(data);
            ID = int.Parse(row[listName[0]].ToString());
            Name = row[listName[1]].ToString();
       
      
        }


    }
}
