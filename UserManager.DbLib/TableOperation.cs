using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.DbLib
{
    //паттерн "заместитель" (репозиторий). Позволяет не привяываться к конкретной СУБД
    public class TableOperation<T>:ITableOperation<T>
    {
        private readonly ITableOperation<T> _db;
        
        public TableOperation(ITableOperation<T> db)
        {
            _db = db;
        }
        
        
        
        public bool Change(string str)
        {
            return _db.Change(str);
        }
        public IEnumerable<T>? FindAll(string str)
        {
            return _db.FindAll(str);
        }
        public T? FindOne(string str)
        {
            return _db.FindOne(str);    
        }
    }
}
