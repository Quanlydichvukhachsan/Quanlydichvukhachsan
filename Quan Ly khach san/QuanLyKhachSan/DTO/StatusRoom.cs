using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class StatusRoom
    {  
        private readonly int _idStatusRoom;
  private readonly string _nameStatusRoom;

        List<string> listName = null;
  public int IdStatusRoom => _idStatusRoom;
   public string NameStatusRoom => _nameStatusRoom;


   public StatusRoom(DataRow row,DataTable data)
        {

             listName = InitNameColumn.init(data);   
  _idStatusRoom = int.Parse(row[listName[0]].ToString());

            _nameStatusRoom =  row[listName[1]].ToString();
                  
        }

    }
}
