using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES.DocumentView.Wizard
{
    public partial class WizardPage : UserControl
    {
        protected WizardPage prevPage, nextPage;
        public string Description { get; set; }
        public WizardPage Next { get; }
        public WizardPage Prev { get; }
        public WizardPage()
        {
            InitializeComponent();
        }
    }
}
