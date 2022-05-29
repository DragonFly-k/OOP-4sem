using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10.db
{
    internal interface IDataService<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        T Insert(T entity);

        T Update(T oldEntity, T entity);

        bool Delete(int id);
    }
}
