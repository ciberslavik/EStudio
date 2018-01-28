using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ES.Settings
{
    [Serializable]
    public class SettingNodeCollection:ICollection<SettingNode>
    {
        
        private List<SettingNode> items = new List<SettingNode>();
        [XmlArray("Items"), XmlArrayItem("Item")]
        public List<SettingNode> Items
        {
            get { return items; }
            set { items = value; }
        }

        private SettingNode parentNode;

        public int Count
        {
            get
            {
                return ((ICollection<SettingNode>)Items).Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<SettingNode>)Items).IsReadOnly;
            }
        }

        public void Add(SettingNode node)
        {
            node.Parent = parentNode;
            Items.Add(node);
            
        }
        public void Remove(SettingNode node)
        {
            Items.Remove(node);
        }

        public void Clear()
        {
            ((ICollection<SettingNode>)Items).Clear();
        }

        public bool Contains(SettingNode item)
        {
            return ((ICollection<SettingNode>)Items).Contains(item);
        }

        public void CopyTo(SettingNode[] array, int arrayIndex)
        {
            ((ICollection<SettingNode>)Items).CopyTo(array, arrayIndex);
        }

        bool ICollection<SettingNode>.Remove(SettingNode item)
        {
            return ((ICollection<SettingNode>)Items).Remove(item);
        }

        public IEnumerator<SettingNode> GetEnumerator()
        {
            return ((ICollection<SettingNode>)Items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<SettingNode>)Items).GetEnumerator();
        }

        public SettingNodeCollection()
        {

        }
        public SettingNodeCollection(SettingNode parentNode)
        {
            this.parentNode = parentNode;
        }
    }
}
