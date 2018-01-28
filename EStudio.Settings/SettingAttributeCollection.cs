using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Settings
{
    [Serializable]
    public class SettingAttributeCollection:ICollection<SettingAttribute>
    {
        List<SettingAttribute> items = new List<SettingAttribute>();

        public SettingAttributeCollection()
        {

        }

        public int Count
        {
            get
            {
                return ((ICollection<SettingAttribute>)items).Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<SettingAttribute>)items).IsReadOnly;
            }
        }

        public void Add(SettingAttribute item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            ((ICollection<SettingAttribute>)items).Clear();
        }

        public bool Contains(SettingAttribute item)
        {
            return ((ICollection<SettingAttribute>)items).Contains(item);
        }

        public void CopyTo(SettingAttribute[] array, int arrayIndex)
        {
            ((ICollection<SettingAttribute>)items).CopyTo(array, arrayIndex);
        }

        public void CopyTo(System.Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<SettingAttribute> GetEnumerator()
        {
            return ((ICollection<SettingAttribute>)items).GetEnumerator();
        }

        public bool Remove(SettingAttribute item)
        {
            return ((ICollection<SettingAttribute>)items).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<SettingAttribute>)items).GetEnumerator();
        }
    }
}
