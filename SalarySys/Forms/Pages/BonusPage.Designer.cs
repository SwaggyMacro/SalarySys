namespace SalarySys.Forms.Pages
{
    partial class BonusPage
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
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiLabel1.Location = new System.Drawing.Point(369, 290);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 57);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Developing...";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // BonusPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 723);
            this.Controls.Add(this.uiLabel1);
            this.Name = "BonusPage";
            this.PageIndex = 10010;
            this.Symbol = 362781;
            this.Text = "奖金发放";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
    }
}