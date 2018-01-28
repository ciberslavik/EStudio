using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Settings
{
    [Serializable]
    public class SettingAttribute
    {
        public string Name { get; set; }
        public Type AttributeType { get; set; }
        public object Value { get; set; }

        public SettingAttribute()
        {

        }
        public SettingAttribute(string name)
        {
            this.Name = name;
        }
    }
}
