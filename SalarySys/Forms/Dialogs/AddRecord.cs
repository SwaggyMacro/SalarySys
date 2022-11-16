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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace SalarySys.Forms.Dialogs
{
    public partial class AddRecord : UIEditForm
    {
        private Dicts.Edit editType;
        private DataOperator.Model.WorkRecord pRecord;
        private DataOperator.BLL.WorkRecord workRecord = new DataOperator.BLL.WorkRecord();
        private DataOperator.BLL.Department department;
        private DataOperator.BLL.Employee employee = new DataOperator.BLL.Employee();
        public AddRecord(Dicts.Edit editType = Dicts.Edit.Add, DataOperator.Model.WorkRecord pRecord = null)
        {
            this.editType = editType;
            if(pRecord != null ) this.pRecord = pRecord;
            InitializeComponent();
            if (editType == Dicts.Edit.Edit) {
                this.Text = "编辑记录";
                this.HandleCreated += InitForm;
            }
        }


        private void InitForm(object sender, EventArgs e) {
            this.Invoke(new Action(() => {
                cbbDepart.Text = employee.GetEmployeeByNo(pRecord.emp_id).depart;
                cbbEmp.Text = pRecord.emp_name;
                udtClockInTime.Value = pRecord.clock_in_time;
                udtClockOffTime.Value = pRecord.clock_off_time;
                tbEmpNo.Text = pRecord.emp_id.ToString();
                iudQuantity.Value = pRecord.quantity;
            }));
        }
        private void InitData()
        {
            this.Invoke(new MethodInvoker(delegate () {
                DataTable dtDrpts = department.GetDepartments();
                foreach (DataRow item in dtDrpts.Rows)
                {
                    cbbDepart.Items.Add(item["name"].ToString());
                }
            }));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataOperator.Model.WorkRecord record = new DataOperator.Model.WorkRecord()
            {
                emp_id = Convert.ToInt32(tbEmpNo.Text),
                emp_name = cbbEmp.Text,
                clock_in_time = Convert.ToDateTime(udtClockInTime.Text),
                clock_off_time = Convert.ToDateTime(udtClockOffTime.Text),
                quantity = iudQuantity.Value
            };
            List<DataOperator.Model.WorkRecord> records = new List<DataOperator.Model.WorkRecord>();
            records.Add(record);
            if (editType == Dicts.Edit.Add)
            {
                if (workRecord.InsertRecord(records) > 0)
                {
                    UIMessageBox.ShowSuccess("添加成功!");
                }
                else
                {
                    UIMessageBox.ShowError("添加失败!");
                }
            }
            else
            {
                pRecord.clock_in_time = record.clock_in_time;
                pRecord.clock_off_time = record.clock_off_time;
                pRecord.quantity = record.quantity;
                if (workRecord.UpdateRecord(pRecord) > 0)
                {
                    UIMessageBox.ShowSuccess("更新成功!");
                }
                else
                {
                    UIMessageBox.ShowError("更新失败!");
                }
            }
        }

        private void tbEmpId_TextChanged(object sender, EventArgs e)
        {
            RefreshEmployeeCombox();
        }
        private void RefreshEmployeeCombox()
        {
            this.Invoke(new MethodInvoker(delegate () {
                DataOperator.Model.Employee pEmployee = employee.GetEmployeeByNo(Convert.ToInt32(tbEmpNo.Text));
                if (pEmployee.name == null || pEmployee.name.Equals("")) return;
                cbbDepart.Text = pEmployee.depart;
                cbbEmp.Text = pEmployee.name;
            }));
        }
    }
}
