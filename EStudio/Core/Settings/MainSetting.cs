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
    public class MainSetting : SettingBase
    {
        AppPaths paths;
        string fullName;
        [XmlElement]
        public AppPaths Paths
        {
            get { return paths; }
            set { paths = value; }
        }

        public override string FullSettingName
        {
            get
            {
                return GetType().FullName;
            }

            set
            {
                fullName = value;
            }
        }

        public MainSetting()
        {
            paths = new AppPaths();
        }
    }
}
