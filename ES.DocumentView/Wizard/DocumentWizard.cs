using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES.DocumentView.Wizard
{
    public partial class DocumentWizard : Form
    {
        protected List<WizardPage> pages = new List<WizardPage>();
        public System.Collections.Generic.List<ES.DocumentView.Wizard.WizardPage> Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public DocumentWizard()
        {
            
            InitializeComponent();
        }
    }
}
