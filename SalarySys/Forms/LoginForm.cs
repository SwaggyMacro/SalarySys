using Sunny.UI;
using DataOperator;
using DataOperator.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarySys.Forms
{
    public partial class LoginForm : UILoginForm
    {
        public LoginForm()
        {
            InitForm();
            InitializeComponent();
        }
        private void InitForm() {
            this.OnLogin += LoginForm_OnLogin;
            DataBase dataBase = new DataBase();
            dataBase.OpenDb();
            if (!dataBase.IsDataBaseExists()) dataBase.CreateDataBase();
        }

        private bool LoginForm_OnLogin(string userName, string password)
        {
            User bUser = new User();
            DataOperator.Model.User user = new DataOperator.Model.User(userName, password);
            if (bUser.Login(user))
            {
                MainForm mainForm = new MainForm();
                mainForm.showDialog(this);
                return true;
            }
            else {
                return false;
            }
        }
    }
}
