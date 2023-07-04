using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.DbLib
{
    //интерфейс подключения к любой базе данных
    public interface ITableOperation<out T>
    {
        public bool Change(string str);
        public IEnumerable<T>? FindAll(string str);
        public T? FindOne(string str);
    }
}
