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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarySys.Forms.Pages
{
    public partial class PositionManagePage : UIPage
    {
        private Position position = new Position();
        public PositionManagePage()
        {
            InitializeComponent();
            uiDataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void RefreshDataTable() {
            this.Invoke(new MethodInvoker(delegate () {
                uiDataGridView1.DataSource = position.GetPositions();
                for (int i = 0; i < uiDataGridView1.Columns.Count; i++)
                {
                    uiDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                uiDataGridView1.Columns[0].HeaderText = "编号";
                uiDataGridView1.Columns[1].HeaderText = "岗位名称";
                uiDataGridView1.Columns[2].HeaderText = "薪资等级";
                uiDataGridView1.Columns[3].HeaderText = "薪水增幅";
                uiDataGridView1.Refresh();
            }));
        }
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            RefreshDataTable();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            Dialogs.AddPosition addPosition = new Dialogs.AddPosition();
            addPosition.ShowDialog();
            RefreshDataTable();
        }

        private void btnDelPosition_Click(object sender, EventArgs e)
        {
            int positionId = Convert.ToInt32 (uiDataGridView1.Rows[uiDataGridView1.SelectedIndex].Cells[0].Value);
            if (position.DelPosition(positionId) > 0) {
                UIMessageBox.ShowSuccess("删除成功!");
                RefreshDataTable();
            }
            else {
                UIMessageBox.ShowError("删除失败!");
            }

        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            DataOperator.Model.Position pPosition = new DataOperator.Model.Position() {
                position_name = uiDataGridView1.CurrentRow.Cells[1].Value.ToString(),
                salary_rank = Convert.ToInt32(uiDataGridView1.CurrentRow.Cells[2].Value),
                salary_growth = Convert.ToInt32(uiDataGridView1.CurrentRow.Cells[3].Value)
            };
            Dialogs.AddPosition addPosition = new Dialogs.AddPosition(Dicts.Edit.Edit, pPosition, Convert.ToInt32(uiDataGridView1.CurrentRow.Cells[0].Value));
            addPosition.ShowDialog();
            RefreshDataTable();
        }
    }
}
