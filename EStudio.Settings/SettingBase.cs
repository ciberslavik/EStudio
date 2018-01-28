using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ES.Settings
{
    [Serializable]
    public abstract class SettingBase
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement]
        public Type EditorTypeName { get; set; }
        [XmlElement]
        public abstract string FullSettingName { get; set; }
    }
}
