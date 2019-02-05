using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class FuncsForCalc
    {

        public static double Mod(double a, double mod)
        {
            return a % mod;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

       public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            else
            {
                return a / b;
            }
        }
    }
}
