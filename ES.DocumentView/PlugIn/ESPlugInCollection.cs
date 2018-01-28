using System;
using System.Collections;
namespace ES.DocumentView.PlugIn
{
    public class ESPlugInCollection:CollectionBase
    {
        public ESPlugin this[int index]
        {
            get
            {
                return ((ESPlugin)List[index]);
            }
            set
            {
                List[index] = value;
            }
        }
        public ESPlugin this[string name]
        {
            get
            {
                return ((ESPlugin)List[IndexOf(name)]);
            }
            set
            {
                List[IndexOf(name)] = value;
            }
        }
        public int Add(ESPlugin value)
        {
            return (List.Add(value));
        }

        public int IndexOf(ESPlugin value)
        {
            return (List.IndexOf(value));
        }
        public int IndexOf(string name)
        {
            int retval = -1;
            for (int i = 0; i < List.Count; i++)
            {
                if (((ESPlugin)List[i]).PlugInName == name)
                {
                    return i;
                }
            }

            return retval;
        }
        public void Insert(int index, ESPlugin value)
        {
            List.Insert(index, value);
        }

        public void Remove(ESPlugin value)
        {
            List.Remove(value);
        }

        public bool Contains(ESPlugin value)
        {
            // If value is not of type ESPlugin, this will return false.
            return (List.Contains(value));
        }

        protected override void OnInsert(int index, Object value)
        {
            // Insert additional code to be run only when inserting values.
        }

        protected override void OnRemove(int index, Object value)
        {
            // Insert additional code to be run only when removing values.
        }

        protected override void OnSet(int index, Object oldValue, Object newValue)
        {
            // Insert additional code to be run only when setting values.
        }

        protected override void OnValidate(Object value)
        {
            //if (value.GetType() != typeof(ESPlugin))
            //    throw new ArgumentException("value must be of type ESPlugin.", "value");
        }

    }
}