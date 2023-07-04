using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.DbLib
{
    //Класс подключения к БД Sqlite
    public class TableOperationSqlite <T>: ITableOperation<T>
    {
        private readonly SqliteConnection _db;//подключениe, доступнoe только для чтения

        public TableOperationSqlite(string connectionString)
        {
            _db=new SqliteConnection(connectionString); 
        }

        public bool Change(string sql)
        {
            _db.Open();
            var command=new SqliteCommand(sql, _db);
            var result=command.ExecuteNonQuery();//получаем кол-во строк

            _db.Close();
            return result>0;
        }

        public IEnumerable<T>? FindAll (string sql)//select вернет много записей
        {
            _db.Open();
            var result = _db.Query<T>(sql);
            _db.Close();
            return result;
        }

        public T? FindOne(string sql)//select вернет одну запись либо пустоту
        {
            _db.Open();
            var result = _db.QuerySingleOrDefault<T?>(sql);//возвращает или экземпляр класса или дефолтное значение
            _db.Close();
            return result;
        }
    }
}
