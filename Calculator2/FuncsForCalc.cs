using System;

namespace Calculator
{
    public class FuncsForCalc
    {
        private double sum;
        
        private double updateSum(double result)
        {
            return sum = sum + result;
        }

        public double Accumulator
        {
            get;
            private set;
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
            Accumulator = Math.Pow(x, exp);
            return updateSum(Accumulator);
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
