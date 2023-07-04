using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.DbLib
{
    //CRUD
    public interface ITable<T>
    {
        public bool Create(T obj);
        public bool Update(T obj);
        public bool Delete(T obj);
        public IEnumerable<T> FindAll();
        public T FindById(int id);//поиск по id
    }
}
