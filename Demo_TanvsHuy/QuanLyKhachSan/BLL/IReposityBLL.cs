using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   internal interface IReposityBLL<T>
    {
        bool Insert(T obj);

        bool UpdateById(string id, T obj);

        bool DeleteById(string id);

        IEnumerable<T> readAll();
    }
}
