using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.BLL
{
    public class WorkRecord
    {
        DAL.WorkRecord workRecord = new DAL.WorkRecord();

        public int DeleteRecord(int id)
        {
            return workRecord.DeleteRecord(id);
        }

        public DataTable GetRecordsBetween(string startDate, string EndDate)
        {
            return workRecord.GetRecordsBetween(startDate, EndDate);
        }

        public int InsertRecord(List<Model.WorkRecord> record)
        {
            return workRecord.InsertRecord(record);
        }

        public int UpdateRecord(Model.WorkRecord record)
        {
            return workRecord.UpdateRecord(record);
        }
    }
}
