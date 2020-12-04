using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO.Service
{
   public class ServiceDTO
    {
        private List<string> listName = null;
        public int ID { get; set; }
        public string Name { get; set; }
        public string NameServiceType { get; set; }
        public int IdService { get; set; }
        public int Price { get; set; }

        public ServiceDTO() { listName = new List<string>(); }
        public ServiceDTO(int iD, string name, int idService, int price ,string nameServiceType)
        {
            ID = iD;
            Name = name;
            IdService = idService;
            Price = price;
            NameServiceType = nameServiceType;
        }

        public ServiceDTO(DataRow row, DataTable data)
        {

            listName = InitNameColumn.init(data);

            ID = int.Parse(row[listName[0]].ToString());
            Name = row[listName[1]].ToString();
            Price = int.Parse(row[listName[2]].ToString());
            NameServiceType = row[listName[3]].ToString();
            IdService = int.Parse(row[listName[4]].ToString());
         
        }
    }
}
