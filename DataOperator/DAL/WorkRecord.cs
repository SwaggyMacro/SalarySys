using DataOperator.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.DAL
{
    public class WorkRecord
    {
        private DbHelper dbHelper = new DbHelper();

        public int InsertRecord(List<Model.WorkRecord> record)
        {
            return dbHelper.InsertRecord(record);
        }

        public DataTable GetRecordsBetween(string startDate, string endDate)
        {
            return dbHelper.GetRecordsBetween(startDate, endDate);
        }

        public int UpdateRecord(Model.WorkRecord record)
        {
            return dbHelper.UpdateRecord(record);
        }

        public int DeleteRecord(int id)
        {
            return dbHelper.DeleteRecord(id);
        }
    }
}
