using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.PlugInInterface
{
    public interface IPlugIn
    {

        List<IToolWindow> ToolWindows { get; set; }
        List<IDocumentTemplate> DocumentTemplates { get; set; }
        List<IWizard> Wizards { get; set; }

        void RegisterServices(PlugInServiceContainer container);
    }
}
