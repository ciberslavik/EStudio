using ES.PlugInInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.PlugInManager
{
    public class PlugInManager
    {
        List<IPlugInService> pluginServices = new List<IPlugInService>();

        public PlugInManager()
        {

        }
    }
}
