using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.BLL
{
    public class Employee
    {
        DAL.Employee employee = new DAL.Employee();

        public int AddEmployee(Model.Employee pEmployee)
        {
            return employee.AddEmployee(pEmployee);
        }

        public DataTable GetEmployees()
        {
            return employee.GetEmployees();
        }

        public DataTable GetEmployees(string depart, string position)
        {
            return employee.GetEmployees(depart, position);
        }

        public int updateEmployee(Model.Employee pEmployee)
        {
            return employee.updateEmployee(pEmployee);
        }

        public int DelEmployee(int emp_no)
        {
            return employee.DelEmployee(emp_no);
        }

        public Model.Employee GetEmployeeByNo(int emp_no)
        {
            return employee.GetEmployeeByNo(emp_no);
        }
    }
}
