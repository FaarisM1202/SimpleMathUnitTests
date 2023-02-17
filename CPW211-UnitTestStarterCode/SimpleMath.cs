using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double a, double b)
        {
            double addition = a + b;
            return addition;
        }

        public static double Subtract(double a, double b)
        {
            double subtraction = a - b;
            return subtraction;
        }

        public static double Multiply(double a, double b)
        {
            double multiplication = a * b;
            return multiplication;
        }

        public static double Divide(double a, double b)
        {
            if(a == 0 || b == 0)
            {
                throw new ArgumentException($"{nameof(Divide)} cannot be 0.");
            }
            double divide = a / b;
            return divide;
        }
    }
}
