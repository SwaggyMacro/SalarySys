
namespace SalarySys.Forms.Dialogs
{
    partial class AddStaff
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tbEmpNo = new Sunny.UI.UITextBox();
            this.tbName = new Sunny.UI.UITextBox();
            this.cbbSex = new Sunny.UI.UIComboBox();
            this.dtpEntryDate = new Sunny.UI.UIDatetimePicker();
            this.cbbPosition = new Sunny.UI.UIComboBox();
            this.iudAge = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.cbDrptName = new Sunny.UI.UIComboBox();
            this.iudSalaryRank = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.rbInWorkshop = new Sunny.UI.UIRadioButton();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.rbNotInWorkshop = new Sunny.UI.UIRadioButton();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 516);
            this.pnlBtm.Size = new System.Drawing.Size(590, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(347, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(41, 72);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(46, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "工号:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(41, 114);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(46, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "姓名:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(41, 159);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(46, 23);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "性别:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(41, 249);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(46, 23);
            this.uiLabel4.TabIndex = 5;
            this.uiLabel4.Text = "年龄:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(41, 297);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(79, 23);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "入职时间:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(41, 345);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(79, 23);
            this.uiLabel6.TabIndex = 7;
            this.uiLabel6.Text = "工作岗位:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbEmpNo
            // 
            this.tbEmpNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmpNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEmpNo.Location = new System.Drawing.Point(94, 70);
            this.tbEmpNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmpNo.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbEmpNo.Name = "tbEmpNo";
            this.tbEmpNo.ShowText = false;
            this.tbEmpNo.Size = new System.Drawing.Size(150, 29);
            this.tbEmpNo.TabIndex = 9;
            this.tbEmpNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbEmpNo.Watermark = "";
            this.tbEmpNo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(94, 113);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbName.Name = "tbName";
            this.tbName.ShowText = false;
            this.tbName.Size = new System.Drawing.Size(150, 29);
            this.tbName.TabIndex = 10;
            this.tbName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbName.Watermark = "";
            this.tbName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbbSex
            // 
            this.cbbSex.DataSource = null;
            this.cbbSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbSex.FillColor = System.Drawing.Color.White;
            this.cbbSex.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbbSex.Location = new System.Drawing.Point(94, 159);
            this.cbbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbSex.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbSex.Size = new System.Drawing.Size(150, 29);
            this.cbbSex.TabIndex = 11;
            this.cbbSex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbSex.Watermark = "";
            this.cbbSex.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.DateFormat = "yyyy/MM/dd HH:mm";
            this.dtpEntryDate.FillColor = System.Drawing.Color.White;
            this.dtpEntryDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEntryDate.Location = new System.Drawing.Point(126, 295);
            this.dtpEntryDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEntryDate.MaxLength = 16;
            this.dtpEntryDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpEntryDate.Size = new System.Drawing.Size(200, 29);
            this.dtpEntryDate.SymbolDropDown = 61555;
            this.dtpEntryDate.SymbolNormal = 61555;
            this.dtpEntryDate.TabIndex = 12;
            this.dtpEntryDate.Text = "2022/11/13 16:42";
            this.dtpEntryDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpEntryDate.Value = new System.DateTime(2022, 11, 13, 16, 42, 47, 318);
            this.dtpEntryDate.Watermark = "";
            this.dtpEntryDate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbbPosition
            // 
            this.cbbPosition.DataSource = null;
            this.cbbPosition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbPosition.FillColor = System.Drawing.Color.White;
            this.cbbPosition.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPosition.Location = new System.Drawing.Point(127, 343);
            this.cbbPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbPosition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbPosition.Size = new System.Drawing.Size(199, 29);
            this.cbbPosition.TabIndex = 13;
            this.cbbPosition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbPosition.Watermark = "";
            this.cbbPosition.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // iudAge
            // 
            this.iudAge.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iudAge.Location = new System.Drawing.Point(94, 248);
            this.iudAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iudAge.MinimumSize = new System.Drawing.Size(100, 0);
            this.iudAge.Name = "iudAge";
            this.iudAge.ShowText = false;
            this.iudAge.Size = new System.Drawing.Size(116, 29);
            this.iudAge.TabIndex = 14;
            this.iudAge.Text = "uiIntegerUpDown1";
            this.iudAge.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.iudAge.Value = 18;
            this.iudAge.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(41, 203);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(46, 23);
            this.uiLabel8.TabIndex = 16;
            this.uiLabel8.Text = "部门:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbDrptName
            // 
            this.cbDrptName.DataSource = null;
            this.cbDrptName.FillColor = System.Drawing.Color.White;
            this.cbDrptName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDrptName.Location = new System.Drawing.Point(94, 203);
            this.cbDrptName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDrptName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDrptName.Name = "cbDrptName";
            this.cbDrptName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDrptName.Size = new System.Drawing.Size(150, 29);
            this.cbDrptName.TabIndex = 17;
            this.cbDrptName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDrptName.Watermark = "";
            this.cbDrptName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // iudSalaryRank
            // 
            this.iudSalaryRank.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iudSalaryRank.HasMaximum = true;
            this.iudSalaryRank.HasMinimum = true;
            this.iudSalaryRank.Location = new System.Drawing.Point(126, 387);
            this.iudSalaryRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iudSalaryRank.Maximum = 10;
            this.iudSalaryRank.MaximumEnabled = true;
            this.iudSalaryRank.Minimum = 0;
            this.iudSalaryRank.MinimumEnabled = true;
            this.iudSalaryRank.MinimumSize = new System.Drawing.Size(100, 0);
            this.iudSalaryRank.Name = "iudSalaryRank";
            this.iudSalaryRank.ShowText = false;
            this.iudSalaryRank.Size = new System.Drawing.Size(200, 29);
            this.iudSalaryRank.TabIndex = 19;
            this.iudSalaryRank.Text = "uiIntegerUpDown1";
            this.iudSalaryRank.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.iudSalaryRank.Value = 10;
            this.iudSalaryRank.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(41, 389);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(79, 23);
            this.uiLabel7.TabIndex = 18;
            this.uiLabel7.Text = "工资等级:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rbInWorkshop
            // 
            this.rbInWorkshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbInWorkshop.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbInWorkshop.Location = new System.Drawing.Point(155, 438);
            this.rbInWorkshop.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbInWorkshop.Name = "rbInWorkshop";
            this.rbInWorkshop.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbInWorkshop.Size = new System.Drawing.Size(55, 29);
            this.rbInWorkshop.TabIndex = 20;
            this.rbInWorkshop.Text = "是";
            this.rbInWorkshop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(41, 439);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(110, 23);
            this.uiLabel9.TabIndex = 21;
            this.uiLabel9.Text = "是否车间员工:";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rbNotInWorkshop
            // 
            this.rbNotInWorkshop.Checked = true;
            this.rbNotInWorkshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNotInWorkshop.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbNotInWorkshop.Location = new System.Drawing.Point(216, 438);
            this.rbNotInWorkshop.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbNotInWorkshop.Name = "rbNotInWorkshop";
            this.rbNotInWorkshop.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbNotInWorkshop.Size = new System.Drawing.Size(55, 29);
            this.rbNotInWorkshop.TabIndex = 22;
            this.rbNotInWorkshop.Text = "否";
            this.rbNotInWorkshop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AddStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(592, 574);
            this.Controls.Add(this.rbNotInWorkshop);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.rbInWorkshop);
            this.Controls.Add(this.iudSalaryRank);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.cbDrptName);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.iudAge);
            this.Controls.Add(this.cbbPosition);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.cbbSex);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmpNo);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "AddStaff";
            this.Text = "添加员工";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.tbEmpNo, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.cbbSex, 0);
            this.Controls.SetChildIndex(this.dtpEntryDate, 0);
            this.Controls.SetChildIndex(this.cbbPosition, 0);
            this.Controls.SetChildIndex(this.iudAge, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.cbDrptName, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.iudSalaryRank, 0);
            this.Controls.SetChildIndex(this.rbInWorkshop, 0);
            this.Controls.SetChildIndex(this.uiLabel9, 0);
            this.Controls.SetChildIndex(this.rbNotInWorkshop, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox tbEmpNo;
        private Sunny.UI.UITextBox tbName;
        private Sunny.UI.UIComboBox cbbSex;
        private Sunny.UI.UIDatetimePicker dtpEntryDate;
        private Sunny.UI.UIComboBox cbbPosition;
        private Sunny.UI.UIIntegerUpDown iudAge;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboBox cbDrptName;
        private Sunny.UI.UIIntegerUpDown iudSalaryRank;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIRadioButton rbInWorkshop;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIRadioButton rbNotInWorkshop;
    }
}