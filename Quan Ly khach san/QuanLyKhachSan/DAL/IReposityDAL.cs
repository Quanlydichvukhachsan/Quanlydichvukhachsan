using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  
     internal interface IReposityDAL<T>
    {
        bool Insert(string query, T obj);

        bool UpdateById(string query, T obj);

        bool DeleteById(string query, T obj);

        IEnumerable<T> readAll(string query);

    }
    
}
