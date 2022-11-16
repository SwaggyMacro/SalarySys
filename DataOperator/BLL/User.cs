using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.BLL
{
    public class User
    {
        private DAL.User daoUser = new DAL.User();
        public bool Login(Model.User user) {
            return daoUser.Login(user);
        }


    }
}
