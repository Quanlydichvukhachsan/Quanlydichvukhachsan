using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO.BillService
{
    public class BillServiceDTO
    {
        private List<string> listName = null;
        public BillServiceDTO(string nameService, int price, int count, int totalPrice)
        {
            this.nameService = nameService;
            Price = price;
            Count = count;
            TotalPrice = totalPrice;
        }
        public BillServiceDTO() { listName = new List<string>(); }
       

        public string nameService { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }

        public BillServiceDTO(DataRow row, DataTable data)
        {

            listName = InitNameColumn.init(data);

            nameService = row[listName[0]].ToString();
            Price = int.Parse(row[listName[1]].ToString());
            Count = int.Parse(row[listName[2]].ToString());
            TotalPrice = int.Parse(row[listName[3]].ToString());
            
        }

    }
}
