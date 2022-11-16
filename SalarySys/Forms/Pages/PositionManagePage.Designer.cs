
namespace SalarySys.Forms.Pages
{
    partial class PositionManagePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditPosition = new Sunny.UI.UISymbolButton();
            this.btnDelPosition = new Sunny.UI.UISymbolButton();
            this.btnAddPosition = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPosition.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditPosition.Location = new System.Drawing.Point(228, 12);
            this.btnEditPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(100, 35);
            this.btnEditPosition.Symbol = 362719;
            this.btnEditPosition.TabIndex = 10;
            this.btnEditPosition.Text = "编辑岗位";
            this.btnEditPosition.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditPosition.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnEditPosition.Click += new System.EventHandler(this.btnEditPosition_Click);
            // 
            // btnDelPosition
            // 
            this.btnDelPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelPosition.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelPosition.Location = new System.Drawing.Point(120, 12);
            this.btnDelPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelPosition.Name = "btnDelPosition";
            this.btnDelPosition.Size = new System.Drawing.Size(100, 35);
            this.btnDelPosition.Symbol = 57423;
            this.btnDelPosition.TabIndex = 9;
            this.btnDelPosition.Text = "删除岗位";
            this.btnDelPosition.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelPosition.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnDelPosition.Click += new System.EventHandler(this.btnDelPosition_Click);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPosition.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddPosition.Location = new System.Drawing.Point(12, 12);
            this.btnAddPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(100, 35);
            this.btnAddPosition.Symbol = 57424;
            this.btnAddPosition.TabIndex = 8;
            this.btnAddPosition.Text = "添加岗位";
            this.btnAddPosition.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddPosition.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(860, 13);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 35;
            this.uiSymbolButton1.Size = new System.Drawing.Size(35, 35);
            this.uiSymbolButton1.Symbol = 57386;
            this.uiSymbolButton1.TabIndex = 7;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(12, 54);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.Size = new System.Drawing.Size(885, 660);
            this.uiDataGridView1.TabIndex = 6;
            this.uiDataGridView1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PositionManagePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 723);
            this.Controls.Add(this.btnEditPosition);
            this.Controls.Add(this.btnDelPosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiDataGridView1);
            this.Name = "PositionManagePage";
            this.PageIndex = 1005;
            this.Text = "岗位管理";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton btnEditPosition;
        private Sunny.UI.UISymbolButton btnDelPosition;
        private Sunny.UI.UISymbolButton btnAddPosition;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
    }
}