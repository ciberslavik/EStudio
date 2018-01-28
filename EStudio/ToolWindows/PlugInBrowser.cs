using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using ES.DocumentView.PlugIn;
using ES.DocumentView.ToolWindows;

namespace EStudio.ToolWindows
{
    public class PlugInBrowser:DockContent
    {
        private TreeView treeView1;
        private Splitter splitter1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button button1;
        private DockPanel panel;
        ESPluginManager plugins;

        ESPlugin selectedPlugin;
        public PlugInBrowser()
        {
            
            InitializeComponent();
            string pluginDir = Path.GetDirectoryName(Application.ExecutablePath) + @"\PlugIn";
            plugins = new ESPluginManager(pluginDir);

            foreach(ESPlugin plugin in plugins.Plugins)
            {
                listBox1.Items.Add(plugin.PlugInName);
            }
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pluginName = (string)listBox1.SelectedItem;
            ESPlugin plugin = plugins.Plugins[pluginName];
            treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode("ToolWindows");
            

            foreach(ToolWindow tool in plugin.ToolWindows)
            {
                string toolTypeName = tool.GetType().Name;
                TreeNode classNameNode = new TreeNode(toolTypeName);
                rootNode.Nodes.Add(classNameNode);
            }
            selectedPlugin = plugin;
            rootNode.Expand();
            treeView1.Nodes.Add(rootNode);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 321);
            this.listBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(120, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(732, 321);
            this.treeView1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(120, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 321);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(757, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlugInBrowser
            // 
            this.ClientSize = new System.Drawing.Size(852, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Name = "PlugInBrowser";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToolWindow window = selectedPlugin.ToolWindows[0];
            DockContent content = new DockContent();
            content.Controls.Add(window);
            window.Dock = DockStyle.Fill;
            content.Show(this.DockPanel);
        }
    }
}
