using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ES.Settings
{
    [Serializable]
    public class SettingNode
    {
        SettingNodeCollection items;
        SettingAttributeCollection attributes;
        [XmlAttribute(AttributeName ="Name")]
        public string Name { get; set; }
        public SettingNodeCollection Child
        {
            get { return items; }
            set { items = value; }
        }
        [XmlIgnore]
        public SettingNode Parent { get; internal set; }
        
        public SettingAttributeCollection Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }

        public SettingNode()
        {
            items = new SettingNodeCollection();
            attributes = new SettingAttributeCollection();
        }   
        public SettingNode(string name)
        {
            this.Name = name;
        }                                                                           

       
    }
}
