using System;
using System.ComponentModel;

//using static Calculator.Funcs;

namespace Calculator
{
    public class Program : Funcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add two numbers!");
            Console.WriteLine("Enter first number:");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{number1} and {number2}");

            Funcs result = new Funcs();

           // result = Add(number1, number2);

            Console.WriteLine("The sum is: "+result);

            Console.ReadKey();
        }
    }
}
