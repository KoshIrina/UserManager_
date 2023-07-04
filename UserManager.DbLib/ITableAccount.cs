using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models;

namespace UserManager.DbLib
{
    public interface ITableAccount : ITable<Account>
    {
        //проверка существования логина и пароля в БД
        public bool ChackLoginPassword(string login, string password);
        
    }
}
