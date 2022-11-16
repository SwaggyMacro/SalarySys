using System;
using System.Data;

namespace DataOperator.DAL
{
    public class Department
    {
        DbHelper dbHelper = new DbHelper();
        public int AddDepart(Model.Department drpt)
        {
            return dbHelper.AddDepart(drpt);
        }

        public DataTable GetDepartments()
        {
            return dbHelper.GetDepartments();
        }

        public int DelDrpt(int drptID)
        {
            return dbHelper.DelPrpt(drptID);
        }

        public int UpdateDepart(Model.Department pDepart)
        {
            return dbHelper.UpdateDepart(pDepart);
        }
    }
}