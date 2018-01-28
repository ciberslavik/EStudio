using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DocumentView.ProjectModel
{
    interface IProjectItem
    {
        string Name { get; set; }
        List<IProjectItem> Child { get; set; }
        IProjectItem Parent { get; set; }

    }
}
