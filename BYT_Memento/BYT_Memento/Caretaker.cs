using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Memento
{
    class Caretaker
    {
        private Object saved;

        public void saveMemento(Writer writer)
        {
            saved = writer.save();
        }
        public void undo(Writer writer)
        {
            writer.undoStuff(saved);
        }
    }
}
