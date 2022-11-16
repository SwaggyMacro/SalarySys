using SalarySys.Forms;
using SalarySys.Forms.Pages;
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

namespace SalarySys
{
    public partial class MainForm : UIHeaderAsideMainFrame
    {
        public MainForm()
        {
            InitializeComponent();
            int pageIndex = 1000;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 57600);
            TreeNode parent = Aside.CreateNode("工资管理", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent, AddPage(new SalaryPage(), ++pageIndex));
            Aside.CreateChildNode(parent, AddPage(new BonusPage(), ++pageIndex));
            //示例设置某个节点的小红点提示
            Aside.ShowTips = true;
            Aside.SetNodeTipsText(Aside.Nodes[0], "6", Color.Red, Color.White);

            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[4], style.DisplayText(), style.Value());
            }
             
            Header.CreateChildNode(Header.Nodes[4], "多彩主题", UIStyle.Colorful.Value());
            Header.SetNodeSymbol(Header.Nodes[4], 61502);
            Aside.SetNodeSymbol(Aside.Nodes[0].Nodes[0], 362417);
            Aside.SetNodeSymbol(Aside.Nodes[0].Nodes[1], 362781);
            parent = Aside.CreateNode("员工管理", 62141, 24, pageIndex);
            Aside.CreateChildNode(parent, AddPage(new EmployeePage(), ++pageIndex));
            Aside.SetNodeSymbol(Aside.Nodes[1].Nodes[0], 62137);
            Aside.CreateChildNode(parent, AddPage(new EmpManagePage(), ++pageIndex));
            Aside.SetNodeSymbol(Aside.Nodes[1].Nodes[1], 62078);
            Aside.CreateChildNode(parent, AddPage(new DepartManagePage(), ++pageIndex));
            Aside.SetNodeSymbol(Aside.Nodes[1].Nodes[2], 61869);
            Aside.CreateChildNode(parent, AddPage(new PositionManagePage(), ++pageIndex));
            Aside.SetNodeSymbol(Aside.Nodes[1].Nodes[3], 62139);
            parent = Aside.CreateNode("薪资分析", 61888, 24, pageIndex);
            //直接增加一个页面，不在左侧列表显示
            AddPage(new FColorful());
            pictureBox1.BackgroundImage = Image.FromFile(@"Resources\Images\logo.png");
        }

        public void showDialog(LoginForm loginForm)
        {
            loginForm.Visible = false;
            this.ShowDialog();
        }
        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void Header_MenuItemClick(string text, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 4:
                    UIStyle style = (UIStyle)pageIndex;
                    if (style != UIStyle.Colorful)
                        StyleManager.Style = style;
                    else
                        SelectPage(pageIndex);

                    break;
                default:
                    Aside.SelectPage(pageIndex);
                    break;
            }
        }
    }
}
