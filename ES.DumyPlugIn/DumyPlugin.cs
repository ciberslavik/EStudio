
using ES.DumyPlugIn.ToolWindows;
using ES.PlugInInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DumyPlugIn
{
    public class DumyPlugin : IPlugIn

    {
        public DumyPlugin()
        {
            
        }

        public List<IDocumentTemplate> DocumentTemplates
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<IToolWindow> ToolWindows
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<IWizard> Wizards
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void RegisterServices(PlugInServiceContainer container)
        {
            throw new NotImplementedException();
        }
    }
}
