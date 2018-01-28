using ES.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStudio.Core
{
    class ESApplicationContext : ApplicationContext
    {
        private MainForm applicationForm;
        
        private ESCore applicationCore;

        private ApplicationSetting setting;
        public ApplicationSetting Setting
        {
            get { return setting; }
            set { setting = value; }
        }
        public ESCore ApplicationCore
        {
            get { return applicationCore; }
            set { applicationCore = value; }
        }
        public MainForm ApplicationForm
        {
            get { return applicationForm; }
            set { applicationForm = value; }
        }
        private static ESApplicationContext instance;
        public static ESApplicationContext GetContext()
        {
            if (instance == null)
                instance = new ESApplicationContext();

            return instance;
        }
        private ESApplicationContext()
        {

            // Handle the ApplicationExit event to know when the application is exiting.

            setting = ApplicationSetting.GetInstance();
            setting.CreateDefaults();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            applicationCore = ESCore.GetCore();
            ApplicationForm = new MainForm();
            ApplicationForm.FormClosed += OnFormClosed;
            ApplicationForm.Show();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            ExitThread();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            

            try
            {
               
            }
            catch { }
        }
    }
}
