using SalarySys.Forms.Dialogs;
using SalarySys.Utils;
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

namespace SalarySys.Forms.Pages
{
    public partial class EmpManagePage : UIPage
    {
        private DataOperator.BLL.Employee employee = new DataOperator.BLL.Employee();
        public EmpManagePage()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.ShowDialog();
            RefreshDataTable();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            RefreshDataTable();
        }
        private void RefreshDataTable()
        {
            this.Invoke(new MethodInvoker(delegate () {
                uiDataGridView1.DataSource = employee.GetEmployees();
                for (int i = 0; i < uiDataGridView1.Columns.Count; i++)
                {
                    uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                uiDataGridView1.Columns[0].HeaderText = "编号";
                uiDataGridView1.Columns[1].HeaderText = "工号";
                uiDataGridView1.Columns[2].HeaderText = "姓名";
                uiDataGridView1.Columns[3].HeaderText = "性别";
                uiDataGridView1.Columns[4].HeaderText = "年龄";
                uiDataGridView1.Columns[5].HeaderText = "部门";
                uiDataGridView1.Columns[6].HeaderText = "入职时间";
                uiDataGridView1.Columns[7].HeaderText = "岗位";
                uiDataGridView1.Columns[8].HeaderText = "工资等级";
                uiDataGridView1.Columns[9].HeaderText = "车间员工";
                uiDataGridView1.Refresh();
            }));
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            DataOperator.Model.Employee pEmployee = new DataOperator.Model.Employee() {
                emp_no = Convert.ToInt32(uiDataGridView1.CurrentRow.Cells[1].Value),
                name = uiDataGridView1.CurrentRow.Cells[2].Value.ToString(),
                sex = uiDataGridView1.CurrentRow.Cells[3].Value.ToString(),
                age = Convert.ToInt32(uiDataGridView1.CurrentRow.Cells[4].Value),
                depart = uiDataGridView1.CurrentRow.Cells[5].Value.ToString(),
                entry_date = Convert.ToDateTime(uiDataGridView1.CurrentRow.Cells[6].Value.ToString()),
                position = uiDataGridView1.CurrentRow.Cells[7].Value.ToString(),
                salary_rank = Convert.ToInt32(uiDataGridView1.CurrentRow.Cells[8].Value),
            };
            if (uiDataGridView1.CurrentRow.Cells[9].Value.ToString().Equals("是")) pEmployee.in_workshop = "yes";
            else pEmployee.in_workshop = "no";
            AddStaff addStaff = new AddStaff(Dicts.Edit.Edit, pEmployee);
            addStaff.ShowDialog();
            RefreshDataTable();
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            int emp_no = Convert.ToInt32(uiDataGridView1.Rows[uiDataGridView1.SelectedIndex].Cells[1].Value);
            if (employee.DelEmployee(emp_no) > 0)
            {
                UIMessageBox.ShowSuccess("删除成功!");
                RefreshDataTable();
            }
            else
            {
                UIMessageBox.ShowError("删除失败!");
            }
        }
    }
        
}
