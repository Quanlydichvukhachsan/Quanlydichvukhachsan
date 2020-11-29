using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  
     internal interface IReposityDAL<T>
    {
        bool Insert(T obj);

        bool UpdateById(T obj);

        bool DeleteById( T obj);

        IEnumerable<T> readAll();

    }
    
}
