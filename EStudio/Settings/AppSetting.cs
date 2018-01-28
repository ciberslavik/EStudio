using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EStudio.Settings
{
    [Serializable]
    public class AppSetting
    {
        private string _filePath;
        private string name;
        private string pluginDirectory;
        public string PluginDirectory
        {
            get { return pluginDirectory; }
            set { pluginDirectory = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public AppSetting()
        {

        }
       
    }
}
