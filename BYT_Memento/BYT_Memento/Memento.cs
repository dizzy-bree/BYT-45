using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Memento
{
    public class Memento
    {
        private readonly String content;

        public Memento(String con)
        {
            content = con;
        }

        public String getContent()
        {
            return content;
        }
    }
}
