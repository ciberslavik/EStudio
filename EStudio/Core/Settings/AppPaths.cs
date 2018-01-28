using ES.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EStudio.Core.Settings
{ 
    [Serializable]
    public class AppPaths:SettingBase
    {
        string fullName = "";
        [XmlElement()]
        public string MainDirectory { get; set; }
        [XmlElement()]
        public string ConfigDirectory { get; set; }
        [XmlElement()]
        public string PlugInDirectory { get; set; }

        public override string FullSettingName
        {
            get
            {
                return this.GetType().FullName;
            }

            set
            {
                fullName = value;
            }
        }

        public AppPaths()
        {

        }
        public AppPaths(string name)
        {
            this.Name = name;
        }
    }
}
