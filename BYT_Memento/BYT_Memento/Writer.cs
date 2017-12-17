using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Memento
{
    public class Writer
    {
        public String content;

        public Writer(String con)
        {
            content = con;
        }
        public Object save()
        {
            return new Memento(content);
        }
        public void undoStuff(Object saved)
        {
            Memento meme = (Memento)saved;
            content = meme.getContent();
        }
        public void write(String txt)
        {
            content += txt;
        }
        public override string ToString()
        {
            return content;
        }
    }
}
