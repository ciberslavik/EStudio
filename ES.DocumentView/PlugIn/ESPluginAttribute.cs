using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DocumentView.PlugIn
{
    [AttributeUsage(AttributeTargets.Assembly ,AllowMultiple = false, Inherited = false)]
    public class ESPluginAttribute :Attribute
    {
        public string PlugInName { get; set; }
        public string PluginDescription { get; set; }
        public Type PlugInClass { get; set; }
    }
}
