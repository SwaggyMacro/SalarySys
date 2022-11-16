using DataOperator.Model;
using SalarySys.Forms.Dialogs;
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
using Utils;

namespace SalarySys.Forms.Pages
{
    public partial class EmployeePage : UIPage
    {
        DataOperator.BLL.WorkRecord workRecord = new DataOperator.BLL.WorkRecord();
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddRecord addRecord = new AddRecord();
            addRecord.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Filter = "MicroSoft Excel文件(*.xlsx)|*.xlsx"; 
            dialog.ShowHelp = true; 

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                ImportExcelData(filePath);
            }
        }
        private void ImportExcelData(string filePath) {
            this.Invoke(new MethodInvoker(delegate () {
                ExcelHelper excelHelper = new ExcelHelper();
                List<DataOperator.Model.WorkRecord> records = excelHelper.ReadWorkRecord(filePath);
                for (int i = 0; i < uiDataGridView1.Columns.Count; i++)
                {
                    uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                workRecord.InsertRecord(records);
                RefreshDataTable(uiDatetimePicker1.Text, uiDatetimePicker2.Text);
                UIMessageBox.ShowSuccess("导入成功！");
            }));
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            DataOperator.Model.WorkRecord record = new WorkRecord()
            {
                id = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells[0].Value),
                emp_name = uiDataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                emp_id = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells[1].Value),
                clock_in_time = Convert.ToDateTime(uiDataGridView1.SelectedRows[0].Cells[3].Value),
                clock_off_time = Convert.ToDateTime(uiDataGridView1.SelectedRows[0].Cells[4].Value),
                quantity = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells[5].Value)
            };
            
            AddRecord addRecord = new AddRecord(Utils.Dicts.Edit.Edit, record);
            addRecord.ShowDialog();
        }
        private void RefreshDataTable(string startTime, string endTime) {
            this.Invoke(new MethodInvoker(delegate ()
            {
                DataTable dt = workRecord.GetRecordsBetween(startTime, endTime);
                uiDataGridView1.DataSource = dt;
                for (int i = 0; i < uiDataGridView1.Columns.Count; i++)
                {
                    uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                uiDataGridView1.Columns[0].HeaderText = "编号";
                uiDataGridView1.Columns[1].HeaderText = "工号";
                uiDataGridView1.Columns[2].HeaderText = "姓名";
                uiDataGridView1.Columns[3].HeaderText = "上班时间";
                uiDataGridView1.Columns[4].HeaderText = "下班时间";
                uiDataGridView1.Columns[5].HeaderText = "计件数量";
            }));
        }
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            RefreshDataTable(uiDatetimePicker1.Text, uiDatetimePicker2.Text);
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in uiDataGridView1.SelectedRows)
            {
                ids.Add(Convert.ToInt32(row.Cells[0].Value));
            }
            foreach (var id in ids)
            {
                workRecord.DeleteRecord(id);
            }
            RefreshDataTable(uiDatetimePicker1.Text, uiDatetimePicker2.Text);
            UIMessageBox.ShowSuccess("删除成功！");
        }

        private void SearchNameInDataTable(string name) {
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
    }
}
