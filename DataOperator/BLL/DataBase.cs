using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace DataOperator.BLL
{
    public class DataBase
    {
        private string dbFile = @"URI=file:.\Database\SalarySys.db";
        private DAL.DbHelper dataBase;
        public DataBase(string dbFile = null)
        {
            if (dbFile == null) this.dbFile = dbFile;
            dataBase = new DAL.DbHelper(dbFile);
        }
        public bool OpenDb()
        {
            return dataBase.OpenDb();
        }
        public bool CreateDataBase()
        {
            return dataBase.CreateDataBase();
        }
        public bool IsDataBaseExists() {
            return dataBase.IsDataBaseExists();
        }
    }
}
