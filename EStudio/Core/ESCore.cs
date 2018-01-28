using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStudio.Settings;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EStudio.Core
{
    public class ESCore
    {
        

        static AppSetting applicationSettings;
        public AppSetting ApplicationSettings
        {
            get { return applicationSettings; }
        }
        #region Singleton
        static ESCore instance;
        public static ESCore GetCore()
        {
            if (instance == null)
                instance = new ESCore();

            return instance;
        }
        #endregion
        private ESCore()
        {
            
            string configFile = Path.GetDirectoryName(Application.ExecutablePath)+ @"\Config\Estudio.config";
            CreateDefaultSetting(configFile);
        }
        void CreateDefaultSetting(string path)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            applicationSettings = new AppSetting();
            applicationSettings.Name = "ElectronicStudio";

            XmlSerializer serializer = new XmlSerializer(applicationSettings.GetType());
            using (FileStream fileStream = new FileStream(path, FileMode.CreateNew))
            {
                serializer.Serialize(fileStream, applicationSettings);
                fileStream.Flush();
                fileStream.Close();
            }

                
            
            
        }
    }
}
