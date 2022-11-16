
namespace SalarySys.Forms.Dialogs
{
    partial class AddRecord
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
            this.cbbDepart = new Sunny.UI.UIComboBox();
            this.cbbEmp = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.udtClockInTime = new Sunny.UI.UIDatetimePicker();
            this.udtClockOffTime = new Sunny.UI.UIDatetimePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.iudQuantity = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tbEmpNo = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 327);
            this.pnlBtm.Size = new System.Drawing.Size(477, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(234, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(68, 126);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(81, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "选择员工:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbbDepart
            // 
            this.cbbDepart.DataSource = null;
            this.cbbDepart.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbDepart.FillColor = System.Drawing.Color.White;
            this.cbbDepart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDepart.Location = new System.Drawing.Point(146, 124);
            this.cbbDepart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbDepart.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbDepart.Name = "cbbDepart";
            this.cbbDepart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbDepart.Size = new System.Drawing.Size(137, 29);
            this.cbbDepart.TabIndex = 3;
            this.cbbDepart.Text = "等待输入工号";
            this.cbbDepart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbDepart.Watermark = "";
            this.cbbDepart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbbEmp
            // 
            this.cbbEmp.DataSource = null;
            this.cbbEmp.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbEmp.FillColor = System.Drawing.Color.White;
            this.cbbEmp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbEmp.Location = new System.Drawing.Point(291, 124);
            this.cbbEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbEmp.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbEmp.Name = "cbbEmp";
            this.cbbEmp.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbEmp.Size = new System.Drawing.Size(137, 29);
            this.cbbEmp.TabIndex = 4;
            this.cbbEmp.Text = "等待输入工号";
            this.cbbEmp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbEmp.Watermark = "";
            this.cbbEmp.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(68, 165);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(80, 23);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "上班时间:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // udtClockInTime
            // 
            this.udtClockInTime.FillColor = System.Drawing.Color.White;
            this.udtClockInTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.udtClockInTime.Location = new System.Drawing.Point(146, 163);
            this.udtClockInTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udtClockInTime.MaxLength = 19;
            this.udtClockInTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.udtClockInTime.Name = "udtClockInTime";
            this.udtClockInTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.udtClockInTime.Size = new System.Drawing.Size(200, 29);
            this.udtClockInTime.SymbolDropDown = 61555;
            this.udtClockInTime.SymbolNormal = 61555;
            this.udtClockInTime.TabIndex = 6;
            this.udtClockInTime.Text = "2022-11-23 16:10:40";
            this.udtClockInTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.udtClockInTime.Value = new System.DateTime(2022, 11, 23, 16, 10, 40, 936);
            this.udtClockInTime.Watermark = "";
            this.udtClockInTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // udtClockOffTime
            // 
            this.udtClockOffTime.FillColor = System.Drawing.Color.White;
            this.udtClockOffTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.udtClockOffTime.Location = new System.Drawing.Point(146, 202);
            this.udtClockOffTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udtClockOffTime.MaxLength = 19;
            this.udtClockOffTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.udtClockOffTime.Name = "udtClockOffTime";
            this.udtClockOffTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.udtClockOffTime.Size = new System.Drawing.Size(200, 29);
            this.udtClockOffTime.SymbolDropDown = 61555;
            this.udtClockOffTime.SymbolNormal = 61555;
            this.udtClockOffTime.TabIndex = 8;
            this.udtClockOffTime.Text = "2022-11-23 16:10:40";
            this.udtClockOffTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.udtClockOffTime.Value = new System.DateTime(2022, 11, 23, 16, 10, 40, 936);
            this.udtClockOffTime.Watermark = "";
            this.udtClockOffTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(68, 204);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(80, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "下班时间:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(68, 243);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(81, 23);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "当日计件:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // iudQuantity
            // 
            this.iudQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iudQuantity.Location = new System.Drawing.Point(146, 241);
            this.iudQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iudQuantity.MinimumSize = new System.Drawing.Size(100, 0);
            this.iudQuantity.Name = "iudQuantity";
            this.iudQuantity.ShowText = false;
            this.iudQuantity.Size = new System.Drawing.Size(200, 29);
            this.iudQuantity.TabIndex = 10;
            this.iudQuantity.Text = "iudQuantity";
            this.iudQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.iudQuantity.Value = 10;
            this.iudQuantity.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(69, 88);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(89, 23);
            this.uiLabel5.TabIndex = 11;
            this.uiLabel5.Text = "员工工号:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbEmpNo
            // 
            this.tbEmpNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmpNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEmpNo.Location = new System.Drawing.Point(146, 85);
            this.tbEmpNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmpNo.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbEmpNo.Name = "tbEmpNo";
            this.tbEmpNo.ShowText = false;
            this.tbEmpNo.Size = new System.Drawing.Size(150, 29);
            this.tbEmpNo.TabIndex = 12;
            this.tbEmpNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbEmpNo.Watermark = "";
            this.tbEmpNo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.tbEmpNo.TextChanged += new System.EventHandler(this.tbEmpId_TextChanged);
            // 
            // AddRecord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(479, 385);
            this.Controls.Add(this.tbEmpNo);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.iudQuantity);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.udtClockOffTime);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.udtClockInTime);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.cbbEmp);
            this.Controls.Add(this.cbbDepart);
            this.Controls.Add(this.uiLabel1);
            this.Name = "AddRecord";
            this.Text = "添加记录";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.cbbDepart, 0);
            this.Controls.SetChildIndex(this.cbbEmp, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.udtClockInTime, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.udtClockOffTime, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.iudQuantity, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.tbEmpNo, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbbDepart;
        private Sunny.UI.UIComboBox cbbEmp;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatetimePicker udtClockInTime;
        private Sunny.UI.UIDatetimePicker udtClockOffTime;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIIntegerUpDown iudQuantity;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox tbEmpNo;
    }
}