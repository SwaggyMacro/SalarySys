using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Net.NetworkInformation;

namespace DataOperator.DAL
{
    public class DbHelper
    {
        private SQLiteConnection conn;
        public DbHelper() { 
            this.dbFile = $@"datetimeformat=CurrentCulture;URI=file:{dbPath}";
            OpenDb();
        }
        public int AddDepart(Model.Department drpt)
        {
            string sql = "INSERT INTO Department(name, depart_no) VALUES (@NAME, @DEPART_NO);";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@NAME", DbType.String),
                new SQLiteParameter("DEPART_NO", DbType.Int32)
            };
            parameters[0].Value = drpt.name;
            parameters[1].Value = drpt.depart_no;
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.Add(parameters[0]);
            cmd.Parameters.Add(parameters[1]);
            return cmd.ExecuteNonQuery();
        }

        public int DelEmployee(int emp_no)
        {
            string sql = "DELETE FROM Employee where emp_no = @EMP_NO";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.Add(new SQLiteParameter("@EMP_NO", DbType.Int32)
            {
                Value = emp_no
            });
            return cmd.ExecuteNonQuery();
        }

        public int UpdatePosition(Model.Position pInfo, int primeKey)
        {
            string sql = $"UPDATE Position SET position_name='{pInfo.position_name}', salary_rank={pInfo.salary_rank}, salary_growth={pInfo.salary_growth} WHERE id={primeKey}";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        public int UpdateDepart(Model.Department pDepart)
        {
            string sql = $"UPDATE Department SET name='{pDepart.name}' WHERE depart_no={pDepart.depart_no}";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        public int DelPrpt(int drptID)
        {
            string sql = "DELETE FROM Department where id = @DEPARTMENT_ID";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.Add(new SQLiteParameter("@DEPARTMENT_ID", DbType.Int32)
            {
                Value = drptID
            });
            return cmd.ExecuteNonQuery();
        }

        public string GetExecutedCommand(string commandText, IDbDataParameter[] dbDataParameters)
         {
             foreach (var parameter in dbDataParameters)
             {
                string pname = parameter.ParameterName;
                 string pvalue = Convert.ToString(parameter.Value);
                 commandText = commandText.Replace(pname, pvalue);
             }
             return commandText;
         }
        public int UpdateEmployee(Model.Employee pEmployee)
        {
            string sql = $"UPDATE Employee SET name='{pEmployee.name}', sex='{pEmployee.sex}', age={pEmployee.age}, depart='{pEmployee.depart}', entry_date='{pEmployee.entry_date}', " +
                $"position='{pEmployee.position}', salary_rank={pEmployee.salary_rank}, in_workshop='{pEmployee.in_workshop}' WHERE emp_no={pEmployee.emp_no}";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@EMP_NO", DbType.Int32),
                new SQLiteParameter("@NAME", DbType.String),
                new SQLiteParameter("@SEX", DbType.String),
                new SQLiteParameter("@AGE", DbType.Int32),
                new SQLiteParameter("@DEPART", DbType.String),
                new SQLiteParameter("@ENTRY_DATE", DbType.DateTime),
                new SQLiteParameter("@POSITION", DbType.String),
                new SQLiteParameter("@SALARY_RANK", DbType.Int32),
                new SQLiteParameter("@IN_WORKSHOP", DbType.Int32),
            };
            parameters[0].Value = pEmployee.emp_no;
            parameters[1].Value = pEmployee.name;
            parameters[2].Value = pEmployee.sex;
            parameters[3].Value = pEmployee.age;
            parameters[4].Value = pEmployee.depart;
            parameters[5].Value = pEmployee.entry_date;
            parameters[6].Value = pEmployee.position;
            parameters[7].Value = pEmployee.salary_rank;
            parameters[8].Value = pEmployee.in_workshop;
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            foreach (var item in parameters)
            {
                cmd.Parameters.Add(item);
            }
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetDepartments()
        {
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select * from Department", conn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            return dt;
        }
        private string dbPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\Database\SalarySys.db";
        private string dbFile;

        public int AddEmployee(Model.Employee pEmployee)
        {
            string sql = "INSERT INTO Employee(emp_no, name, sex, age, depart, entry_date, position, salary_rank. in_workshop) VALUES(@EMP_NO, @NAME, @SEX, @AGE, @DEPART, @ENTRY_DATE, @POSITION, @SALARY_RANK, @IN_WORKSHOP);";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@EMP_NO", DbType.Int32),
                new SQLiteParameter("@NAME", DbType.String),
                new SQLiteParameter("@SEX", DbType.String),
                new SQLiteParameter("@AGE", DbType.Int32),
                new SQLiteParameter("@DEPART", DbType.String),
                new SQLiteParameter("@ENTRY_DATE", DbType.DateTime),
                new SQLiteParameter("@POSITION", DbType.String),
                new SQLiteParameter("@SALARY_RANK", DbType.Int32),
                new SQLiteParameter("@IN_WORKSHOP", DbType.Int32),
            };
            parameters[0].Value = pEmployee.emp_no;
            parameters[1].Value = pEmployee.name;
            parameters[2].Value = pEmployee.sex;
            parameters[3].Value = pEmployee.age;
            parameters[4].Value = pEmployee.depart;
            parameters[5].Value = pEmployee.entry_date;
            parameters[6].Value = pEmployee.position;
            parameters[7].Value = pEmployee.salary_rank;
            parameters[8].Value = pEmployee.in_workshop;
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            foreach (var item in parameters)
            {
                cmd.Parameters.Add(item);
            }
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetEmployees()
        {
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select * from Employee", conn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                if (item["in_workshop"].ToString().Equals("yes"))
                {
                    item["in_workshop"] = "是";
                }
                else
                {
                    item["in_workshop"] = "否";
                }
            }
            return dt;
        }

        public bool Login(Model.User user)
        {
            string sql = "select * from User where user_name = @USER_NAME and password = @PASSWORD";
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@USER_NAME", DbType.String),
                    new SQLiteParameter("@PASSWORD", DbType.String)
            };
            parameters[0].Value = user.UserName;
            parameters[1].Value = user.Password;
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            foreach (var item in parameters)
            {
                cmd.Parameters.Add(item);
            }
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<Model.User> users = new List<Model.User>();
            while (reader.Read())
            {
                Model.User tmpUser = new Model.User(reader["user_name"].ToString(), reader["password"].ToString(), reader["permission"].ToString());
                users.Add(tmpUser);
            }
            foreach (var item in users)
            {
                if (item.UserName == user.UserName)
                {
                    return true;
                }
            }
            return false;
        }

        public int DelPosition(int positionId)
        {
            string sql = "DELETE FROM Position where id = @POSITION_ID";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.Add(new SQLiteParameter("@POSITION_ID", DbType.Int32) { 
                Value = positionId
            });
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetPositions()
        {
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select * from Position", conn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            return dt;
        }

        public int AddPosition(Model.Position pInfo)
        {
            string sql = "INSERT INTO Position(position_name, salary_rank, salary_growth) VALUES (@POSITION_NAME, @SALARY_RANK, @SALARY_GROWTH);";
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@POSITION_NAME", DbType.String),
                    new SQLiteParameter("@SALARY_RANK", DbType.String),
                    new SQLiteParameter("@SALARY_GROWTH", DbType.Int32)
            };
            parameters[0].Value = pInfo.position_name;
            parameters[1].Value = pInfo.salary_rank;
            parameters[2].Value = pInfo.salary_growth;
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            foreach (var item in parameters)
            {
                cmd.Parameters.Add(item);
            }
            return cmd.ExecuteNonQuery();
        }

        public DbHelper(string dbFile = null) {
            if(dbFile != null) this.dbFile = dbFile;
        }
        public bool OpenDb() {
            try
            {
                dbFile = $@"datetimeformat=CurrentCulture;URI=file:{dbPath}";
                conn = new SQLiteConnection(dbFile);
                conn.Open();
                return true;
            }
            catch (Exception ex){
                LogHelper.WriteLog(ex.Message);
                throw new Exception("打开数据库：" + dbFile + "的连接失败：" + ex.Message);
            }
        }

        public bool IsDataBaseExists()
        {
            if (File.Exists(dbPath)) return true;
            else return false;
        }

        public bool CreateDataBase() {
            string sql = FileUtil.ReadFileString(@".\Resources\Database\database.sql");
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                LogHelper.WriteLog(ex.Message);
                throw new Exception(ex.Message);
            }
            return true;
        }

        private Model.Employee ToEntity(SQLiteDataAdapter adapter) {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count <= 0) { return new Model.Employee(); }
            Model.Employee employee = new Model.Employee()
            {
                emp_no = Convert.ToInt32(dt.Rows[0]["emp_no"]),
                name = dt.Rows[0]["name"].ToString(),
                sex = dt.Rows[0]["sex"].ToString(),
                age = Convert.ToInt32(dt.Rows[0]["age"]),
                depart = dt.Rows[0]["depart"].ToString(),
                entry_date = Convert.ToDateTime(dt.Rows[0]["entry_date"]),
                position = dt.Rows[0]["position"].ToString(),
                salary_rank = Convert.ToInt32(dt.Rows[0]["salary_rank"]),
                in_workshop = dt.Rows[0]["in_workshop"].ToString()
            };
            return employee;
        }
        public Model.Employee GetEmployeeByNo(int emp_no)
        {
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter($"select * from Employee where emp_no = {emp_no}", conn);
            Model.Employee employee = ToEntity(mAdapter);
            return employee;
        }
        public Model.Employee GetEmployeeById(int id)
        {
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter($"select * from Employee where id = {id}", conn);
            Model.Employee employee = ToEntity(mAdapter);
            return employee;
        }

        public int InsertRecord(List<Model.WorkRecord> record)
        {
            int affectedRows = 0;
            string sql = "INSERT INTO WorkRecord(emp_id, emp_name, clock_in_time, clock_off_time, quantity) VALUES (@EMP_ID, @EMP_NAME, @CLOCK_IN_TIME, @CLOCK_OFF_TIME, @QUANTITY);";
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@EMP_ID", DbType.Int32),
                    new SQLiteParameter("@EMP_NAME", DbType.String),
                    new SQLiteParameter("@CLOCK_IN_TIME", DbType.DateTime),
                    new SQLiteParameter("@CLOCK_OFF_TIME", DbType.DateTime),
                    new SQLiteParameter("@QUANTITY", DbType.Int32)
            };
            foreach (var item in record)
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                parameters[0].Value = item.emp_id;
                parameters[1].Value = item.emp_name;
                parameters[2].Value = item.clock_in_time;
                parameters[3].Value = item.clock_off_time;
                parameters[4].Value = item.quantity;
                cmd.Parameters.Clear();
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
                affectedRows += cmd.ExecuteNonQuery();
            }
            return affectedRows;
        }

        public DataTable GetRecordsBetween(string startDate, string endDate)
        {
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter($"select * from WorkRecord where clock_in_time > '{startDate}' and clock_in_time < '{endDate}'", conn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            return dt;
        }

        public int UpdateRecord(Model.WorkRecord record)
        {
            DateTime cit = record.clock_in_time;
            DateTime cot = record.clock_off_time;
            string sql = $"UPDATE WorkRecord SET clock_in_time = '{cit.ToString("yyyy-MM-ddTHH:mm:ss")}', clock_off_time = '{cot.ToString("yyyy-MM-ddTHH:mm:ss")}', quantity = {record.quantity} where id = {record.id}";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        public int DeleteRecord(int id)
        {
            string sql = "DELETE FROM WorkRecord where id = @ID";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.Add(new SQLiteParameter("@ID", DbType.Int32)
            {
                Value = id
            });
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetEmployees(string depart, string position)
        {
            SQLiteDataAdapter mAdapter;
            if (depart != "all" && position != "all")
            {
                mAdapter = new SQLiteDataAdapter($"select * from Employee where depart = '{depart}' and position = '{position}'", conn);
            }
            else if (depart != "all") {
                mAdapter = new SQLiteDataAdapter($"select * from Employee where depart = '{depart}'", conn);
            }
            else if (position != "all")
            {
                mAdapter = new SQLiteDataAdapter($"select * from Employee where position = '{position}'", conn);
            }
            else
            {
                mAdapter = new SQLiteDataAdapter($"select * from Employee", conn);
            }
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                if (item["in_workshop"].ToString().Equals("yes"))
                {
                    item["in_workshop"] = "是";
                }
                else
                {
                    item["in_workshop"] = "否";
                }
            }
            return dt;
        }
        private bool IsSalaryExists(Model.Salaries pSalaries) {
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter($"select * from Salaries where year = {pSalaries.year} and month = {pSalaries.month} and emp_no = {pSalaries.emp_no}", conn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            return dt.Rows.Count > 0 ? true : false;
        }
        public int UpdateSalary(Model.Salaries pSalaries)
        {
            bool isSalaryExists = IsSalaryExists(pSalaries);
            if (isSalaryExists)
            {
                string sql = $"UPDATE Salaries SET Score = {pSalaries.score} WHERE emp_no={pSalaries.emp_no} and year = {pSalaries.year} and month = {pSalaries.month}";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                return cmd.ExecuteNonQuery();
            }
            else {
                string sql = "INSERT INTO Salaries(year, month, emp_no, emp_name, age, sex, depart, position, in_workshop, score) VALUES (@YEAR, @MONTH, @EMP_NO" +
                    ", @EMP_NAME, @AGE, @SEX, @DEPART, @POSITION, @IN_WORKSHOP, @SCORE);";
                SQLiteParameter[] parameters = {
                    new SQLiteParameter("@YEAR", DbType.Int32),
                    new SQLiteParameter("@MONTH", DbType.Int32),
                    new SQLiteParameter("@EMP_NO", DbType.Int32),
                    new SQLiteParameter("@EMP_NAME", DbType.String),
                    new SQLiteParameter("@AGE", DbType.Int32),
                    new SQLiteParameter("@SEX", DbType.String),
                    new SQLiteParameter("@DEPART", DbType.String),
                    new SQLiteParameter("@POSITION", DbType.String),
                    new SQLiteParameter("@IN_WORKSHOP", DbType.String),
                    new SQLiteParameter("@SCORE", DbType.Int32),
                 };
                parameters[0].Value = pSalaries.year;
                parameters[1].Value = pSalaries.month;
                parameters[2].Value = pSalaries.emp_no;
                parameters[3].Value = pSalaries.emp_name;
                parameters[4].Value = pSalaries.age;
                parameters[5].Value = pSalaries.sex;
                parameters[6].Value = pSalaries.depart;
                parameters[7].Value = pSalaries.position;
                parameters[8].Value = pSalaries.in_workshop;
                parameters[9].Value = pSalaries.score;
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                foreach (var item in parameters)
                {
                    cmd.Parameters.Add(item);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }
}