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
    public partial class AddPosition : UIEditForm
    {
        DataOperator.BLL.Position position = new DataOperator.BLL.Position();
        private Dicts.Edit editType = Dicts.Edit.Add;
        private int primeKey;
        public AddPosition(Dicts.Edit editType = Dicts.Edit.Add, DataOperator.Model.Position pPosition = null, int primeKey = -1)
        {
            InitializeComponent();
            this.editType = editType;
            this.primeKey = primeKey;
            if (editType == Dicts.Edit.Edit)
            {
                tbPositionName.Text = pPosition.position_name;
                iudSalaryGrowth.Value = pPosition.salary_growth;
                iudSalaryRank.Value = pPosition.salary_rank;
            }
            this.Text = "编辑岗位";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataOperator.Model.Position pInfo = new DataOperator.Model.Position();
            pInfo.position_name = tbPositionName.Text;
            pInfo.salary_rank = iudSalaryRank.Value;
            pInfo.salary_growth = iudSalaryGrowth.Value;


            if (editType == Dicts.Edit.Add)
            {
                if (position.AddPosition(pInfo) > 0)
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
                if (position.UpdatePosition(pInfo, primeKey) > 0)
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
