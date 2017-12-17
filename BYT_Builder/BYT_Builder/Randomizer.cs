using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Builder
{
    class Randomizer
    {
        public static int random()
        {
            Random rand = new Random();
            int i = rand.Next(3);
            return i;
        }
    }
}
