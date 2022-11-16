
namespace SalarySys.Forms
{
    partial class SalaryPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbDepart = new Sunny.UI.UIComboBox();
            this.cbbPosition = new Sunny.UI.UIComboBox();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiIntegerUpDown1 = new Sunny.UI.UIIntegerUpDown();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDepart
            // 
            this.cbbDepart.DataSource = null;
            this.cbbDepart.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbDepart.FillColor = System.Drawing.Color.White;
            this.cbbDepart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDepart.Location = new System.Drawing.Point(89, 14);
            this.cbbDepart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbDepart.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbDepart.Name = "cbbDepart";
            this.cbbDepart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbDepart.Size = new System.Drawing.Size(150, 29);
            this.cbbDepart.TabIndex = 0;
            this.cbbDepart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbDepart.Watermark = "";
            this.cbbDepart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbbPosition
            // 
            this.cbbPosition.DataSource = null;
            this.cbbPosition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbPosition.FillColor = System.Drawing.Color.White;
            this.cbbPosition.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPosition.Location = new System.Drawing.Point(246, 14);
            this.cbbPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbPosition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbPosition.Size = new System.Drawing.Size(150, 29);
            this.cbbPosition.TabIndex = 1;
            this.cbbPosition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbPosition.Watermark = "";
            this.cbbPosition.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.DateFormat = "yyyy-MM";
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDatePicker1.Location = new System.Drawing.Point(404, 14);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 7;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.ShowType = Sunny.UI.UIDateType.YearMonth;
            this.uiDatePicker1.Size = new System.Drawing.Size(115, 29);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.TabIndex = 2;
            this.uiDatePicker1.Text = "2022-12";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.uiDatePicker1.Watermark = "";
            this.uiDatePicker1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(856, 14);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 35;
            this.uiSymbolButton1.Size = new System.Drawing.Size(35, 35);
            this.uiSymbolButton1.Symbol = 57386;
            this.uiSymbolButton1.TabIndex = 8;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(10, 100);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(885, 591);
            this.uiDataGridView1.TabIndex = 9;
            this.uiDataGridView1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiDataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellEndEdit);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(7, 15);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(81, 23);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "筛选条件:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(416, 53);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(142, 35);
            this.uiButton1.TabIndex = 11;
            this.uiButton1.Text = "设置下表所有人";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiIntegerUpDown1
            // 
            this.uiIntegerUpDown1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiIntegerUpDown1.HasMaximum = true;
            this.uiIntegerUpDown1.HasMinimum = true;
            this.uiIntegerUpDown1.Location = new System.Drawing.Point(143, 56);
            this.uiIntegerUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown1.Maximum = 100;
            this.uiIntegerUpDown1.MaximumEnabled = true;
            this.uiIntegerUpDown1.Minimum = 0;
            this.uiIntegerUpDown1.MinimumEnabled = true;
            this.uiIntegerUpDown1.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.ShowText = false;
            this.uiIntegerUpDown1.Size = new System.Drawing.Size(116, 29);
            this.uiIntegerUpDown1.TabIndex = 13;
            this.uiIntegerUpDown1.Text = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiIntegerUpDown1.Value = 100;
            this.uiIntegerUpDown1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(266, 53);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(142, 35);
            this.uiButton2.TabIndex = 14;
            this.uiButton2.Text = "设置选中人员";
            this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(7, 59);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(134, 23);
            this.uiLabel2.TabIndex = 15;
            this.uiLabel2.Text = "快捷设置绩效分:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(563, 704);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(110, 23);
            this.uiLabel3.TabIndex = 22;
            this.uiLabel3.Text = "在结果中搜索:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.UseCompatibleTextRendering = true;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(676, 701);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(219, 29);
            this.uiTextBox1.TabIndex = 21;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiTextBox1.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Location = new System.Drawing.Point(566, 53);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(193, 35);
            this.uiSymbolButton2.Symbol = 362306;
            this.uiSymbolButton2.TabIndex = 23;
            this.uiSymbolButton2.Text = "生成工资Excel表格";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SalaryPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 742);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiIntegerUpDown1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiDatePicker1);
            this.Controls.Add(this.cbbPosition);
            this.Controls.Add(this.cbbDepart);
            this.Name = "SalaryPage";
            this.PageIndex = 1001;
            this.Text = "工资发放";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox cbbDepart;
        private Sunny.UI.UIComboBox cbbPosition;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
    }
}