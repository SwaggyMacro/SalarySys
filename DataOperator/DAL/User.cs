using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.DAL
{
    public class User
    {
        private DbHelper dbHelper = new DbHelper();
        public bool Login(Model.User user) {
            return dbHelper.Login(user);
        }
    }
}
