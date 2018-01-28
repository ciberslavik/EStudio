using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ES.DocumentView.PlugIn
{
    public class ESPluginManager
    {
        ESPlugInCollection plugins = new ESPlugInCollection();
        public ESPlugInCollection Plugins
        {
            get { return plugins; }
            set { plugins = value; }
        }
        public ESPluginManager(string pluginDirectory)
        {
            if(Directory.Exists(pluginDirectory))
            {
                foreach(string dir in Directory.GetDirectories(pluginDirectory))
                {
                    DirectoryInfo currentDir = new DirectoryInfo(dir);
                    foreach(FileInfo f in currentDir.GetFiles("*.dll"))
                    {
                        ESPlugin plugin = LoadPlugIn(f.FullName);
                        if(plugin!=null)
                            plugins.Add(plugin);
                    }
                }
            }
        }
        private ESPlugin LoadPlugIn(string dllPath)
        {
            Assembly assm = Assembly.LoadFile(dllPath);
            ESPlugin retval = null;
            if (assm != null)
            {
                ESPluginAttribute pluginAttribute = assm.GetCustomAttribute(typeof(ESPluginAttribute)) as ESPluginAttribute;
                if (pluginAttribute != null)
                {
                    ConstructorInfo pluginConstructor = pluginAttribute.PlugInClass.GetConstructor(new Type[] { });
                    if(pluginConstructor!=null)
                    {
                        retval = pluginConstructor.Invoke(new object[] { }) as ESPlugin;
                        if(retval!=null)
                        {
                            retval.PlugInName = pluginAttribute.PlugInName;
                        }
                    }
                    
                    
                }
            }
            return retval;
        }

        
    }
}
