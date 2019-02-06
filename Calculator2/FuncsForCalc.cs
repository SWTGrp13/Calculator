using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class FuncsForCalc
    {
        public double Accumulator
        {
            get;
            private set;
        }

        public double Mod(double a, double mod)
        {
            return a % mod;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a -= b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

       public double Division(double a, double b)
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
