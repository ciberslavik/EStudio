using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES.DocumentView.ToolWindows
{
    public class ToolWindow:UserControl
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ToolWindow
            // 
            this.Name = "ToolWindow";
            this.Size = new System.Drawing.Size(188, 233);
            this.ResumeLayout(false);

        }
    }
}
