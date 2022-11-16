
namespace SalarySys.Forms.Dialogs
{
    partial class AddPosition
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
            this.iudSalaryRank = new Sunny.UI.UIIntegerUpDown();
            this.tbPositionName = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.iudSalaryGrowth = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 257);
            this.pnlBtm.Size = new System.Drawing.Size(369, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(126, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // iudSalaryRank
            // 
            this.iudSalaryRank.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iudSalaryRank.HasMaximum = true;
            this.iudSalaryRank.HasMinimum = true;
            this.iudSalaryRank.Location = new System.Drawing.Point(114, 111);
            this.iudSalaryRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iudSalaryRank.Maximum = 10;
            this.iudSalaryRank.MaximumEnabled = true;
            this.iudSalaryRank.Minimum = 1;
            this.iudSalaryRank.MinimumEnabled = true;
            this.iudSalaryRank.MinimumSize = new System.Drawing.Size(100, 0);
            this.iudSalaryRank.Name = "iudSalaryRank";
            this.iudSalaryRank.ShowText = false;
            this.iudSalaryRank.Size = new System.Drawing.Size(116, 29);
            this.iudSalaryRank.TabIndex = 18;
            this.iudSalaryRank.Text = "uiIntegerUpDown1";
            this.iudSalaryRank.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.iudSalaryRank.Value = 10;
            this.iudSalaryRank.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbPositionName
            // 
            this.tbPositionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPositionName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPositionName.Location = new System.Drawing.Point(114, 67);
            this.tbPositionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPositionName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPositionName.Name = "tbPositionName";
            this.tbPositionName.ShowText = false;
            this.tbPositionName.Size = new System.Drawing.Size(150, 29);
            this.tbPositionName.TabIndex = 17;
            this.tbPositionName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPositionName.Watermark = "";
            this.tbPositionName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(31, 113);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(83, 23);
            this.uiLabel4.TabIndex = 16;
            this.uiLabel4.Text = "薪水等级:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(31, 67);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(83, 23);
            this.uiLabel2.TabIndex = 15;
            this.uiLabel2.Text = "岗位名称:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // iudSalaryGrowth
            // 
            this.iudSalaryGrowth.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iudSalaryGrowth.Location = new System.Drawing.Point(114, 157);
            this.iudSalaryGrowth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iudSalaryGrowth.Maximum = 10;
            this.iudSalaryGrowth.Minimum = 1;
            this.iudSalaryGrowth.MinimumSize = new System.Drawing.Size(100, 0);
            this.iudSalaryGrowth.Name = "iudSalaryGrowth";
            this.iudSalaryGrowth.ShowText = false;
            this.iudSalaryGrowth.Size = new System.Drawing.Size(116, 29);
            this.iudSalaryGrowth.TabIndex = 20;
            this.iudSalaryGrowth.Text = "uiIntegerUpDown1";
            this.iudSalaryGrowth.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.iudSalaryGrowth.Value = 300;
            this.iudSalaryGrowth.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(31, 159);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(83, 23);
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = "薪水增幅:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AddPosition
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(371, 315);
            this.Controls.Add(this.iudSalaryGrowth);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.iudSalaryRank);
            this.Controls.Add(this.tbPositionName);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel2);
            this.Name = "AddPosition";
            this.Text = "添加岗位";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.tbPositionName, 0);
            this.Controls.SetChildIndex(this.iudSalaryRank, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.iudSalaryGrowth, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIIntegerUpDown iudSalaryRank;
        private Sunny.UI.UITextBox tbPositionName;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIIntegerUpDown iudSalaryGrowth;
        private Sunny.UI.UILabel uiLabel1;
    }
}