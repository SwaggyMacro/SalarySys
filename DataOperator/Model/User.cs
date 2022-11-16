using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.Model
{
    public class User
    {
        public User(string userName = null, string password = null, string permission = null) {
            if (userName != null && password != null)
            {
                this.UserName = userName;
                this.Password = password;
            }
            if (permission != null) Permission = permission;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
    }
}
