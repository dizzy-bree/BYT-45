using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Calculator
{
    public class Vars
    {
        private String calcMethod;
        private double var1;
        private double var2;
        public Vars(double val1, double val2, String method)
        {
            var1 = val1;
            var2 = val2;
            calcMethod = method;
        }
        public String getCalcMethod()
        {
            return calcMethod;
        }
        public double getVariable1()
        {
            return var1;
        }

        public double getVariable2()
        {
            return var2;
        }

    }
 
}
