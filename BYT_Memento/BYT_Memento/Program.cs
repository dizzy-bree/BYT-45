using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            Writer writer = new Writer("For the ");
            writer.write("Horde");
            Console.Write(writer);
            caretaker.saveMemento(writer);
            writer.write(" and Azeroth!");
            Console.WriteLine(writer);
            caretaker.undo(writer);
            Console.WriteLine(writer);
        }
    }
}
