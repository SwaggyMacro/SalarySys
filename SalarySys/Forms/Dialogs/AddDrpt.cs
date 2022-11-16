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
    public partial class AddDrpt : UIEditForm
    {
        DataOperator.BLL.Department department = new DataOperator.BLL.Department();
        private Dicts.Edit editType;
        private DataOperator.Model.Department pDepartment;

        public AddDrpt(Dicts.Edit editType = Dicts.Edit.Add, DataOperator.Model.Department pDepartment = null)
        {
            InitializeComponent();
            this.editType = editType;
            this.pDepartment = pDepartment;
            if (editType == Dicts.Edit.Add)
            {
                this.Text = "添加部门";
                GetLastDrptNo();
            }
            else
            {
                this.Text = "编辑部门";
            }
            if (editType == Dicts.Edit.Edit)
            {
                tbDrptNo.Text = pDepartment.depart_no.ToString();
                tbDrptNo.Enabled = false;
                tbDrptName.Text = pDepartment.name;
            }
        }
        private void GetLastDrptNo()
        {
            DataTable dt = department.GetDepartments();
            if (dt.Rows.Count != 0) tbDrptNo.Text = (Convert.ToInt32(dt.Rows[dt.Rows.Count - 1].ItemArray[2]) + 1).ToString();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataOperator.Model.Department pDepart = new DataOperator.Model.Department() { 
                name = tbDrptName.Text,
                depart_no = Convert.ToInt32(tbDrptNo.Text)
            };
            

            if (editType == Dicts.Edit.Add)
            {
                if (department.AddDepart(pDepart) > 0)
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
                if (department.UpdateDepart(pDepart) > 0)
                {
                    UIMessageBox.ShowSuccess("更新成功!");
                }
                else
                {
                    UIMessageBox.ShowError("更新失败!");
                }
            }
        }
    }
}
