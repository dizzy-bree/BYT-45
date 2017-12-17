using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Calculator
{
     public abstract class ChainResponsibility
    {
        public abstract void sendToNextChain(ChainResponsibility nextChain);
        
       public abstract void calculate(Vars variables);
    }
    
    }

