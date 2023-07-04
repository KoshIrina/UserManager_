using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models;

namespace UserManager.DbLib
{

    public class TableAccount:ITableAccount
    {
        private readonly ITableAccount _table;


        public TableAccount(ITableAccount table)
        {
            _table=table;
        }

        //проверка существования логина и пароля в БД
        public bool ChackLoginPassword(string login, string password)
        {
            return _table.ChackLoginPassword(login, password);  
        }






        public bool Create(Account obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Account obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> FindAll()
        {
            throw new NotImplementedException();
        }

        public Account FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account obj)
        {
            throw new NotImplementedException();
        }
    }
}
