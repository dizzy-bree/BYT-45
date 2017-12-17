using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainResponsibility chain1 = new AddVar();
            ChainResponsibility chain2 = new SubstractVar();
            ChainResponsibility chain3 = new MultiplyVar();
            ChainResponsibility chain4 = new DivideVar();

            chain1.sendToNextChain(chain2);
            chain2.sendToNextChain(chain3);
            chain3.sendToNextChain(chain4);

            Vars variables = new Vars(2, 2, "+");
                chain1.calculate(variables);

            Vars variables1 = new Vars(4, 1, "-");
            chain2.calculate(variables1);

            Vars variables3 = new Vars(5, 6, "*");
            chain1.calculate(variables3);

            Vars variables4 = new Vars(5, 6, "/");
            chain1.calculate(variables4);

            Vars variables5 = new Vars(5, 6, "demogorgon");
            chain1.calculate(variables5);
        }
    }
}
