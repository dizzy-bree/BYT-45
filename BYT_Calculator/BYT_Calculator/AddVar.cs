using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Calculator
{
   public class AddVar : ChainResponsibility
    {
         ChainResponsibility nextChain; 
	    public override void sendToNextChain(ChainResponsibility nextChain) {
		// TODO Auto-generated method stub
		this.nextChain = nextChain;
	}

	
	public override void calculate(Vars variables) {
		if(variables.getCalcMethod() == "+"){
			Console.WriteLine(variables.getVariable1()+variables.getVariable2());
		} else {
			nextChain.calculate(variables);
		}
	}
    }
}
