using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ES.PlugInInterface
{
    public interface IDocumentTemplate
    {
        IDocumentTemplate Child { get; set; }
    }
}