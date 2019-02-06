using System;
using System.Security.Cryptography;

namespace Calculator
{
    public class FuncsForCalc
    {
        public void resetSum()
        {
            sum = 0;
        }
        
        public double getSum()
        {
            return sum;
        }

        private double sum;
        
        private double updateSum(double result)
        {
            return sum = result;
        }

        public double Mod(double a, double mod)
        {
            return updateSum(a % mod);
        }

        public double Add(double a, double b)
        {
            return updateSum(a+b);
        }

        public double Subtract(double a, double b)
        {
            return updateSum(a -= b);
        }

        public double Multiply(double a, double b)
        {
            return updateSum(a*b);
        }

        public double Power(double x, double exp)
        {
            return updateSum(Math.Pow(x, exp));
        }

       public double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            else
            {
                return updateSum(a/b);
            }
        }

    }
}
