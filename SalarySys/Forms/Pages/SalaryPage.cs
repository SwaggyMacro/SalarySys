using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarySys.Forms
{
    public partial class SalaryPage : UIPage
    {
        DataOperator.BLL.Department department = new DataOperator.BLL.Department();
        DataOperator.BLL.Employee employee = new DataOperator.BLL.Employee();
        DataOperator.BLL.Position position = new DataOperator.BLL.Position();
        DataOperator.BLL.Salaries salaries = new DataOperator.BLL.Salaries();
        public SalaryPage()
        {
            InitializeComponent();
            this.HandleCreated += InitForm;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            RefreshDataTable();
        }
        private void InitForm(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                cbbPosition.Items.Add("全部");
                cbbDepart.Items.Add("全部");
                position.GetPositions().Rows.Cast<DataRow>().ToList().ForEach(row =>
            {
                cbbPosition.Items.Add(row["position_name"].ToString());
            });
                department.GetDepartments().Rows.Cast<DataRow>().ToList().ForEach(row =>
                {
                    cbbDepart.Items.Add(row["name"].ToString());
                });
                cbbPosition.SelectedIndex = 0;
                cbbDepart.SelectedIndex = 0;

            }));
        }
        private void RefreshDataTable()
        {
            this.Invoke(new MethodInvoker(delegate () {
                uiDataGridView1.ClearAll();
                uiDataGridView1.DataSource = employee.GetEmployees(cbbDepart.Text.Replace("全部", "all"), cbbPosition.Text.Replace("全部", "all"));
                for (int i = 0; i < uiDataGridView1.Columns.Count; i++)
                {
                    uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                uiDataGridView1.Columns[0].HeaderText = "编号";
                uiDataGridView1.Columns[1].HeaderText = "员工号";
                uiDataGridView1.Columns[2].HeaderText = "姓名";
                uiDataGridView1.Columns[3].HeaderText = "性别";
                uiDataGridView1.Columns[4].HeaderText = "年龄";
                uiDataGridView1.Columns[5].HeaderText = "部门";
                uiDataGridView1.Columns[6].HeaderText = "入职时间";
                uiDataGridView1.Columns[7].HeaderText = "职位";
                uiDataGridView1.Columns[8].HeaderText = "薪水等级";
                uiDataGridView1.Columns[9].HeaderText = "是否车间员工";
                uiDataGridView1.Columns[6].Visible = false;
                uiDataGridView1.Columns[8].Visible = false;
                uiDataGridView1.Columns.Insert(10, new DataGridViewTextBoxColumn());
                uiDataGridView1.Columns[10].HeaderText = "绩效得分";
                foreach (DataGridViewTextBoxColumn column in uiDataGridView1.Columns)
                {
                    column.ReadOnly = true;
                }
                uiDataGridView1.Columns[10].ReadOnly = false;
                uiDataGridView1.Refresh();
            }));
        }

        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                var row = uiDataGridView1.Rows[e.RowIndex];
                var id = row.Cells[0].Value.ToString();
                if (row.Cells[10].Value != null) return;
                var score = row.Cells[10].Value.ToString();
                DataOperator.Model.Salaries pSalaries = new DataOperator.Model.Salaries()
                {
                    emp_name = row.Cells[2].Value.ToString(),
                    emp_no = Convert.ToInt32(row.Cells[1].Value),
                    sex = row.Cells[3].Value.ToString(),
                    age = Convert.ToInt32(row.Cells[4].Value),
                    depart = row.Cells[5].Value.ToString(),
                    position = row.Cells[7].Value.ToString(),
                    in_workshop = row.Cells[9].Value.ToString().Equals("是") ? "yes" : "no",
                    score  = Convert.ToInt32(row.Cells[10].Value),
                    month = uiDatePicker1.Value.Month,
                    year = uiDatePicker1.Value.Year
                };
                salaries.UpdateSalary(pSalaries);
            }
        }
        private void SearchNameInDataTable(string name)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                foreach (DataGridViewRow row in uiDataGridView1.Rows)
                {
                    if (row.Cells[2].Value == null) continue;
                    if (row.Cells[2].Value.ToString().Contains(name))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }));
        }
        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
            SearchNameInDataTable(uiTextBox1.Text);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                foreach (DataGridViewRow row in uiDataGridView1.SelectedRows)
                {
                    DataOperator.Model.Salaries pSalaries = new DataOperator.Model.Salaries()
                    {
                        emp_name = row.Cells[2].Value.ToString(),
                        emp_no = Convert.ToInt32(row.Cells[1].Value),
                        sex = row.Cells[3].Value.ToString(),
                        age = Convert.ToInt32(row.Cells[4].Value),
                        depart = row.Cells[5].Value.ToString(),
                        position = row.Cells[7].Value.ToString(),
                        in_workshop = row.Cells[9].Value.ToString().Equals("是") ? "yes" : "no",
                        score = uiIntegerUpDown1.Value,
                        month = uiDatePicker1.Value.Month,
                        year = uiDatePicker1.Value.Year
                    };
                    salaries.UpdateSalary(pSalaries);
                }
                RefreshDataTable();
            }));
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                foreach (DataGridViewRow row in uiDataGridView1.Rows)
                {
                    DataOperator.Model.Salaries pSalaries = new DataOperator.Model.Salaries()
                    {
                        emp_name = row.Cells[2].Value.ToString(),
                        emp_no = Convert.ToInt32(row.Cells[1].Value),
                        sex = row.Cells[3].Value.ToString(),
                        age = Convert.ToInt32(row.Cells[4].Value),
                        depart = row.Cells[5].Value.ToString(),
                        position = row.Cells[7].Value.ToString(),
                        in_workshop = row.Cells[9].Value.ToString().Equals("是") ? "yes" : "no",
                        score = uiIntegerUpDown1.Value,
                        month = uiDatePicker1.Value.Month,
                        year = uiDatePicker1.Value.Year
                    };
                    salaries.UpdateSalary(pSalaries);
                }
                RefreshDataTable();
            }));
        }
    }
}
