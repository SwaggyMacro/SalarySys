using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.BLL
{
    public class Department
    {
        DAL.Department department = new DAL.Department();
        public int AddDepart(Model.Department drpt) {
            return department.AddDepart(drpt);
        }

        public DataTable GetDepartments()
        {
            return department.GetDepartments();
        }

        public int DelDrpt(int drptID)
        {
            return department.DelDrpt(drptID);
        }

        public int UpdateDepart(Model.Department pDepart)
        {
            return department.UpdateDepart(pDepart);
        }
    }
}
