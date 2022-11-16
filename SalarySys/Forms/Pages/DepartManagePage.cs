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
    public partial class DepartManagePage : UIPage
    {
        DataOperator.BLL.Department department = new DataOperator.BLL.Department();
        public DepartManagePage()
        {
            InitializeComponent();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            RefreshDataTable();
        }

        private void btnAddDprt_Click(object sender, EventArgs e)
        {
            AddDrpt addDrpt = new AddDrpt();
            addDrpt.ShowDialog();
            RefreshDataTable();
        }

        private void RefreshDataTable()
        {
            this.Invoke(new MethodInvoker(delegate () {
                uiDataGridView1.DataSource = department.GetDepartments();
                for (int i = 0; i < uiDataGridView1.Columns.Count; i++)
                {
                    uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                uiDataGridView1.Columns[0].HeaderText = "编号";
                uiDataGridView1.Columns[2].HeaderText = "部门号";
                uiDataGridView1.Columns[1].HeaderText = "部门名";
                uiDataGridView1.Refresh();
            }));
        }

        private void btnEditDprt_Click(object sender, EventArgs e)
        {
            DataOperator.Model.Department pDepartment = new DataOperator.Model.Department()
            {
                name  = uiDataGridView1.CurrentRow.Cells[1].Value.ToString(),
                depart_no = Convert.ToInt32(uiDataGridView1.CurrentRow.Cells[2].Value),
            };
            Dialogs.AddDrpt addDrpt = new Dialogs.AddDrpt(Dicts.Edit.Edit, pDepartment);
            addDrpt.ShowDialog();
            RefreshDataTable();
        }

        private void btnDelDprt_Click(object sender, EventArgs e)
        {
            int drptID = Convert.ToInt32(uiDataGridView1.Rows[uiDataGridView1.SelectedIndex].Cells[0].Value);
            if (department.DelDrpt(drptID) > 0)
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
