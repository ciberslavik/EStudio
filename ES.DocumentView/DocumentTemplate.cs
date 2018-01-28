using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DocumentView
{
    public abstract class DocumentTemplate
    {
        public abstract Document CreateDocument();
    }
}
