using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataOperator.Model;
using System.Reflection;
using System.Data;
using System.Collections;

namespace Utils
{
    public class ExcelHelper
    {
        /// <summary>
        /// Read work record through a excel file, the template as
        /// emp name - emp no - clock in time - clock off time - quantity
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<WorkRecord> ReadWorkRecord(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    List<WorkRecord> records = new List<WorkRecord>();
                    int nums = reader.ResultsCount;
                    for (int i = 0; i < nums; i++)
                    {
                        int rows = reader.RowCount;
                        int cols = reader.FieldCount;
                        reader.Read(); // skip the table header
                        for (int index = 0; index < rows; index++)
                        {

                            reader.Read();
                            string[] line = new string[cols];
                            for (int j = 0; j < cols; j++)
                            {
                                line[j] = reader.GetValue(j).ToString();
                            }
                            WorkRecord record = new WorkRecord()
                            {
                                emp_name = line[0],
                                emp_id = Convert.ToInt32(line[1]),
                                clock_in_time = Convert.ToDateTime(line[2]),
                                clock_off_time = Convert.ToDateTime(line[3]),
                                quantity = Convert.ToInt32(line[4])
                            };
                            records.Add(record);
                        }
                        reader.NextResult();
                    }
                    return records;
                }
            }
        }
        public DataTable AddSeriNumToDataTable(DataTable dt)
        {
            DataTable dtNew;
            if (dt.Columns.IndexOf("序号") >= 0)
            {
                dtNew = dt;
            }
            else
            {
                int rowLength = dt.Rows.Count;
                int colLength = dt.Columns.Count;
                DataRow[] newRows = new DataRow[rowLength];
                dtNew = new DataTable();
                dtNew.Columns.Add("序号");
                for (int i = 0; i < colLength; i++)
                {
                    dtNew.Columns.Add(dt.Columns[i].ColumnName);
                    for (int j = 0; j < rowLength; j++)
                    {
                        if (newRows[j] == null)
                            newRows[j] = dtNew.NewRow();
                        newRows[j][i + 1] = dt.Rows[j][i];
                    }
                }
                foreach (DataRow row in newRows)
                {
                    dtNew.Rows.Add(row);
                }

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtNew.Rows[i]["序号"] = i + 1;
            }
            return dtNew;
        }
        public DataTable ToDataTable<T>(IEnumerable<T> list)
        {
            PropertyInfo[] modelItemType = typeof(T).GetProperties();
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(modelItemType.Select(Columns => new DataColumn(Columns.Name, Columns.PropertyType)).ToArray());
            if (list.Count() > 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in modelItemType)
                    {
                        object obj = pi.GetValue(list.ElementAt(i), null);
                        tempList.Add(obj);
                    }
                    object[] dataRow = tempList.ToArray();
                    dataTable.LoadDataRow(dataRow, true);
                }
            }
            return dataTable;
        }
    }
}
