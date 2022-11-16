using DataOperator.BLL;
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

namespace SalarySys.Forms.Dialogs
{
    public partial class AddStaff : UIEditForm
    {
        private Dicts.Edit editType;
        private DataOperator.Model.Employee pEmployee;
        Employee employee = new Employee();
        Position position = new Position();
        public AddStaff(Dicts.Edit editType = Dicts.Edit.Add, DataOperator.Model.Employee pEmployee = null)
        {
            this.editType = editType;
            this.pEmployee = pEmployee;
            InitializeComponent();
            if (editType == Dicts.Edit.Add)
            {
                this.Text = "添加员工";
            }
            else {
                this.Text = "编辑员工";
            }
            GetLastEmpNo();
            if (editType == Dicts.Edit.Edit)
            {
                tbEmpNo.Text = pEmployee.emp_no.ToString();
                tbName.Text = pEmployee.name;
                cbbPosition.Text = pEmployee.position;
                cbbSex.Text = pEmployee.sex;
                cbDrptName.Text = pEmployee.depart;
                dtpEntryDate.Value = pEmployee.entry_date;
                iudAge.Value = pEmployee.age;
                iudSalaryRank.Value = pEmployee.salary_rank;
                if (pEmployee.in_workshop.Equals("yes"))
                {
                    rbInWorkshop.Checked = true;
                }
                else {
                    rbNotInWorkshop.Checked = false;
                }
            }
            GetDepartments();
        }
         
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataOperator.Model.Employee pEmployee = new DataOperator.Model.Employee() {
                emp_no = Convert.ToInt32(tbEmpNo.Text),
                name = tbName.Text,
                sex = cbbSex.Text,
                age = iudAge.Value,
                depart = cbDrptName.Text,
                entry_date = dtpEntryDate.Value,
                position = cbbPosition.Text,
                salary_rank = iudSalaryRank.Value,
            };
            if (rbInWorkshop.Checked)
            {
                pEmployee.in_workshop = "yes";
            }
            else
            {
                pEmployee.in_workshop = "no";
            }
            if (editType == Dicts.Edit.Add)
            {
                if (employee.AddEmployee(pEmployee) > 0)
                {
                    UIMessageBox.ShowSuccess("添加成功!");
                }
                else
                {
                    UIMessageBox.ShowError("添加失败!");
                }
            }
            else {
                if (employee.updateEmployee(pEmployee) > 0)
                {
                    UIMessageBox.ShowSuccess("更新成功!");
                }
                else
                {
                    UIMessageBox.ShowError("更新失败!");
                }
            }
        }
        private void RefreshPositions() {
            this.Invoke(new MethodInvoker(delegate () {
                List<DataOperator.Model.Position> p = position.GetPositionsByList();
                foreach (var item in p)
                {
                    cbbPosition.Items.Add(item.position_name);
                }
            }));
        }
        private void GetDepartments()
        {
            Department department = new Department();
            DataTable dt = department.GetDepartments();
            foreach (DataRow item in dt.Rows)
            {
                cbDrptName.Items.Add(item["name"].ToString());
            }
        }
        private void GetLastEmpNo() {
            DataTable dt = employee.GetEmployees();
            if(dt.Rows.Count != 0) tbEmpNo.Text = (Convert.ToInt32 (dt.Rows[dt.Rows.Count - 1].ItemArray[1]) + 1).ToString();
        }
        private void AddStaff_Load(object sender, EventArgs e)
        {
            RefreshPositions();
        }
    }
}
