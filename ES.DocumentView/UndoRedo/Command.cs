using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DocumentView.UndoRedo
{
    public abstract class Command
    {
        public abstract void Redo(Document document);
        public abstract void Undo(Document document);
    }
}
