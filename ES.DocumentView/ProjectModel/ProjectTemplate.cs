using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DocumentView.ProjectModel
{
    public abstract class ProjectTemplate
    {
        protected List<DocumentTemplate> documentTemplates = new List<DocumentTemplate>();

        public abstract Project CreateProject(string projectName);
    }
}
