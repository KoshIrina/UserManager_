using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models;

namespace UserManager.DbLib
{
    //Класс работы с таблицей аккаунтов
    //Класс не будет знать, к какой БД будем подключаться
    public class TableAccountsSql:ITableAccount
    {
        private readonly TableOperation<Account> _tableOperation;

        public TableAccountsSql(ITableOperation<Account> source)//через заместитель соединяемся с нужной БД
        {
            _tableOperation=new TableOperation<Account>(source);
        }

        //проверка существования логина и пароля в БД
        public bool ChackLoginPassword(string login, string password)
        {
            var sql = $"SELECT id, login, password, is_active FROM table_accounts WHERE login='{login}' AND password='{password}'";//передаем в переменную запрос
            var result= _tableOperation.FindOne(sql);
            return result is not null;
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
