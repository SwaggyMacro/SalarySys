using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.BLL
{
    public class Salaries
    {
        DAL.Salaries salaries = new DAL.Salaries();

        public int UpdateSalary(Model.Salaries pSalaries)
        {
            return salaries.UpdateSalary(pSalaries);
        }
    }
}
