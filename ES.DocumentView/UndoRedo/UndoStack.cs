using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DocumentView.UndoRedo
{
    public class UndoStack
    {
        private List<Command> items = new List<Command>();
        //Command receiver document
        private Document document;

        private int currentIndex = -1;

        /// <summary>
        /// Проверяет возможна ли отмена
        /// </summary>
        public bool CanUndo { get { return items.Count > 0; } }
        /// <summary>
        /// Проверяет возможен ли повтор
        /// </summary>
        public bool CanRedo { get { return items.Count > 0 && currentIndex < items.Count - 1; } }
        public UndoStack(Document document)
        {
            this.document = document;
        }
        public void Add(Command command)
        {
            items.Add(command);
            this.currentIndex++;
        }
        public void Undo()
        {
            if (!CanUndo)
                return;
            items[currentIndex].Undo(document);
            this.currentIndex--;
        }
        public void Redo()
        {
            if (!CanRedo)
                return;
            this.currentIndex++;
            items[currentIndex].Redo(document);
        }
    }
}
