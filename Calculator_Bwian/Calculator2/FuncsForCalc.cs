using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class FuncsForCalc
    {
        public double Add(double a, double b) //Hey!!!
        {
            return a + b;
        }

        public double Subtract(double a, double b) //NEJJJJ!!!!!!!!!!
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Division(double a, double b)
        {
            try
            {
                if (b == 0)
                    throw new System.DivideByZeroException();
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("NOOO! THE WORLD WILL IMPLOOOOOODDDDEEEE!!!");
                throw;
            }
        }
    }
}
