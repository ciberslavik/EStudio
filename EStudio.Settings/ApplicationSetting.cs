using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace ES.Settings
{
    public class ApplicationSetting
    {
        static ApplicationSetting instance;
        public static ApplicationSetting GetInstance()
        {
            if (instance == null)
                instance = new ApplicationSetting();

            return instance;
        }
        public static ApplicationSetting LoadConfiguration(string configDirectory)
        {
            if (instance == null)
                instance = new ApplicationSetting(configDirectory);

            return instance;
        }

     
        public void CreateDefaults()
        {
            SettingNode appSetting = new SettingNode();
            appSetting.Name = "ApplicationMainSetting";
            

            //SettingAttribute applicationPathAtr = new SettingAttribute("ApplicationPath");
            //applicationPathAtr.AttributeType = typeof(string);
            string str = Path.GetDirectoryName(Application.ExecutablePath);

            str = str.Remove(str.Length - 4);

            string settingsDirectory = str + "\\Settings";

            if (!Directory.Exists(settingsDirectory))
                Directory.CreateDirectory(settingsDirectory);


            //applicationPathAtr.Value = str;

            //SettingAttribute pluginDirAttr = new SettingAttribute("PlugInDirectory");
            //pluginDirAttr.AttributeType = typeof(string);
            //pluginDirAttr.Value = "PlugIns";



            //pathSection.Attributes.Add(applicationPathAtr);
            //pathSection.Attributes.Add(pluginDirAttr);
            MainSetting mainSet = new MainSetting();
            paths = new AppPaths("PathsConfig");
            paths.MainDirectory = str;
            paths.ConfigDirectory = "Settings";
            paths.PlugInDirectory = "PlugIns";
            mainSet.Paths = paths;
            //appSetting.Child.Add(paths);
            XmlSerializer serializer = new XmlSerializer(mainSet.GetType());

            string mainSettingFile = settingsDirectory + "\\Main.conf";
            if (File.Exists(mainSettingFile))
                File.Delete(mainSettingFile);

            using (FileStream fileStream = new FileStream(mainSettingFile, FileMode.CreateNew))
            {
                serializer.Serialize(fileStream, mainSet);
                fileStream.Flush();
                fileStream.Close();
            }
            StringWriter sw = new StringWriter();

            serializer.Serialize(sw, mainSet);
            string text = sw.GetStringBuilder().ToString();

            StringReader rdr = new StringReader(text);
            // XmlReader rdr = XmlReader.Create()

            AppPaths pat1 = serializer.Deserialize(rdr) as AppPaths;
            if(pat1!=null)
            {

            }

        }


        private string configurationDirectory = "";
        private ApplicationSetting()
        {

        }
        private ApplicationSetting(string configDirectory)
        {

        }
        
    }
}
