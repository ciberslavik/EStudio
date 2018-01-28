using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace ES.PlugInInterface
{
    public interface IWizard
    {
        string Name { get; set; }
        List<WizardPage> Pages { get; set; }
        Image ProjectIcon { get; set; }
    }
}