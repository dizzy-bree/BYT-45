using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Calculator
{
     public class DivideVar : ChainResponsibility
    {
        private ChainResponsibility nextChain;

        public override void sendToNextChain(ChainResponsibility nextChain)
        {
            this.nextChain = nextChain;
        }
        public override void calculate(Vars variables)
        {
            if(variables.getCalcMethod() =="/")
            {
                Console.WriteLine(variables.getVariable1() / variables.getVariable2());
            }
            else
            {
                Console.WriteLine("Err");
            }
        }
    }
}
