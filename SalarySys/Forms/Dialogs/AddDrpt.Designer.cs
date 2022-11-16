
namespace SalarySys.Forms.Dialogs
{
    partial class AddDrpt
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
            this.tbDrptNo = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tbDrptName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 233);
            this.pnlBtm.Size = new System.Drawing.Size(338, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(95, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbDrptNo
            // 
            this.tbDrptNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDrptNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDrptNo.Location = new System.Drawing.Point(129, 76);
            this.tbDrptNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDrptNo.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbDrptNo.Name = "tbDrptNo";
            this.tbDrptNo.ShowText = false;
            this.tbDrptNo.Size = new System.Drawing.Size(150, 29);
            this.tbDrptNo.TabIndex = 23;
            this.tbDrptNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbDrptNo.Watermark = "";
            this.tbDrptNo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(46, 76);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(83, 23);
            this.uiLabel2.TabIndex = 21;
            this.uiLabel2.Text = "部门号:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbDrptName
            // 
            this.tbDrptName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDrptName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDrptName.Location = new System.Drawing.Point(129, 131);
            this.tbDrptName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDrptName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbDrptName.Name = "tbDrptName";
            this.tbDrptName.ShowText = false;
            this.tbDrptName.Size = new System.Drawing.Size(150, 29);
            this.tbDrptName.TabIndex = 25;
            this.tbDrptName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbDrptName.Watermark = "";
            this.tbDrptName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(46, 131);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(83, 23);
            this.uiLabel1.TabIndex = 24;
            this.uiLabel1.Text = "部门名称:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AddDrpt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 291);
            this.Controls.Add(this.tbDrptName);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.tbDrptNo);
            this.Controls.Add(this.uiLabel2);
            this.Name = "AddDrpt";
            this.Text = "添加部门";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.tbDrptNo, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.tbDrptName, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox tbDrptNo;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbDrptName;
        private Sunny.UI.UILabel uiLabel1;
    }
}