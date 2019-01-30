using System;
//using static System.Math;

namespace Calculator
{
    public class Funcs
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            var sum = a - b;
            return sum;
        }

        public double Multiply(double a, double b)
        {
            var sum = a * b;
            return sum;
        }

        public double Power(double x, double exp)
        {
            var sum = Math.Pow(x, exp);
            return sum;
        }
    }
}