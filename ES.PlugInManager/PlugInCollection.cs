using ES.PlugInInterface;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.PlugInManager
{
    public class PlugInCollection
    {
        List<IPlugIn> items = new List<IPlugIn>();

        public PlugInCollection()
        {

        }
        public void AddPlugIn(IPlugIn plugin)
        {

        }
        public bool PlugInExist(IPlugIn plugin)
        {
            return true;
        }
    }
}
