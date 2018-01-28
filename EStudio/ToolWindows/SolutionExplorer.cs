using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using System.IO;
using ES.DocumentView.PlugIn;

namespace EStudio.ToolWindows
{
    public class SolutionExplorer:DockContent
    {
        private System.Windows.Forms.TreeView treeView1;
        public SolutionExplorer(DockPanel panel)
        {
            this.DockPanel = panel;
            InitializeComponent();
            treeView1.BackColor = this.DockPanel.Theme.ColorPalette.MainWindowActive.Background;

        }
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Решение");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Root");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Решение";
            treeNode2.Name = "";
            treeNode2.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(284, 262);
            this.treeView1.TabIndex = 0;
            // 
            // SolutionExplorer
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.treeView1);
            this.Name = "SolutionExplorer";
            //this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockRight;
            this.Text = "Обозреватель решений";
            this.ResumeLayout(false);

        }
    }
}
