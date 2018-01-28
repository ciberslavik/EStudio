using EStudio.Core;
using EStudio.ToolWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EStudio
{
    public partial class MainForm : Form
    {
        static ESCore core;
        private readonly ToolStripRenderer _toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();
        private SolutionExplorer solExplorer;
        private PlugInBrowser pluginBrowser;
        private VS2015DarkTheme vS2015DarkTheme1;

        public MainForm()
        {
            InitializeComponent();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();

            AutoScaleMode = AutoScaleMode.Dpi;
            this.IsMdiContainer = true;
            vsToolStripExtender1.DefaultRenderer = _toolStripProfessionalRenderer;
            dockPanel1.Theme = vS2015DarkTheme1;
            solExplorer = new SolutionExplorer(dockPanel1);
            
            pluginBrowser = new PlugInBrowser();

            solExplorer.MdiParent = this;
            pluginBrowser.MdiParent = this;

            solExplorer.Show();
            pluginBrowser.Show(dockPanel1);

            solExplorer.DockState = DockState.DockRight;
            solExplorer.DockAreas = (DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.DockBottom);

            pluginBrowser.DockState = DockState.Document;
            pluginBrowser.DockAreas = (DockAreas.Document);

            SetStyle(mainMenu);
            SetStyle(toolStrip);
            SetStyle(statusBar);
            
        }
        public void SetStyle(ToolStrip strip)
        {
            vsToolStripExtender1.SetStyle(strip, VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015DarkTheme1);
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            
        }

        public void LoadDefaultLayout()
        {

        }
    }
}
