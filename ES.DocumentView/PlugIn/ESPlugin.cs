using ES.DocumentView.ToolWindows;
using ES.DocumentView.ProjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DocumentView.PlugIn
{
    public class ESPlugin
    {
        protected List<ToolWindow> toolWindows = new List<ToolWindow>();
        public List<ToolWindow> ToolWindows
        {
            get { return toolWindows; }
            set { toolWindows = value; }
        }
        protected List<ProjectTemplate> projectTemplates = new List<ProjectTemplate>();
        public List<ProjectTemplate> ProjectTemplates
        {
            get { return projectTemplates; }
            set { projectTemplates = value; }
        }
        public string PlugInName { get; set; }
        public string PlugInDescription { get; set; }
    }
}
