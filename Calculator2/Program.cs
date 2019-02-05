using System;
using System.Linq;
using Calculator;

namespace Calculator2
{
    class Program : FuncsForCalc
    {
        private static readonly string[] Operations = {"+", "-", "*", "/", "^", "%"};

        static void Main(string[] args)
        {
            double result = 0;
            double firstNumber = SetNumber("Type you first number : ");
            double secondNumber = SetNumber("Type you second number: ");

            string stringOperation = SetOperation("Enter the operation + (Add), - (Subtract), * (Multiply), / (Division) or ^ (Power):");

            switch (stringOperation)
            {
                case "+":
                case "Add":
                    result = Add(firstNumber, secondNumber);
                    break;
                case "-":
                case "Subtract":
                    result = Subtract(firstNumber, secondNumber);
                    break;
                case "*":
                case "Multiply":
                    result = Multiply(firstNumber, secondNumber);
                    break;
                case "/":
                case "division":
                    result = Division(firstNumber, secondNumber);
                    break;
                case "^":
                case "Power":
                    result = Power(firstNumber, secondNumber);
                    break;
            }

            Console.WriteLine("Result of {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
            Console.ReadKey();
        }

        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return double.Parse(tempInput);
        }

        private static bool IsValidOperation(string input)
        {
            return Operations.Contains(input);
        }

        private static string SetOperation(string outputText)
        {
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }

            return tempInput;
        }
    }
}