using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.DAL
{
    public class Salaries
    {
        private DbHelper dbHelper = new DbHelper();
        public int UpdateSalary(Model.Salaries pSalaries)
        {
            return dbHelper.UpdateSalary(pSalaries);
        }
    }
}
