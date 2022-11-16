using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.DAL
{
    public class Employee
    {
        private DbHelper dbHelper = new DbHelper();
        public int AddEmployee(Model.Employee pEmployee) {
            return dbHelper.AddEmployee(pEmployee);
        }

        public DataTable GetEmployees()
        {
            return dbHelper.GetEmployees();
        }

        public int updateEmployee(Model.Employee pEmployee)
        {
            return dbHelper.UpdateEmployee(pEmployee);
        }

        public int DelEmployee(int emp_no)
        {
            return dbHelper.DelEmployee(emp_no);
        }

        public Model.Employee GetEmployeeByNo(int emp_no)
        {
            return dbHelper.GetEmployeeByNo(emp_no);
        }

        public DataTable GetEmployees(string depart, string position)
        {
            return dbHelper.GetEmployees(depart, position);
        }
    }
}
