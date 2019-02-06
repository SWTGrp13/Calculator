using System;
using System.Linq;
using Calculator;

namespace Calculator2
{
    class Program
    {
        private static readonly string[] Operations = {"+", "-", "*", "/", "^", "%"};

        static void Main(string[] args)
        {
            FuncsForCalc calculator = new FuncsForCalc();
            double result = 0;
            double firstNumber = SetNumber("Type your first number : ");
            double secondNumber = SetNumber("Type your second number: ");

            string stringOperation = SetOperation("Enter the operation: + (Add), - (Subtract), * (Multiply), / (Division), % (Mod) or ^ (Power):");

            switch (stringOperation)
            {
                case "+":
                case "Add":
                    result = calculator.Add(firstNumber, secondNumber);
                    break;
                case "-":
                case "Subtract":
                    result = calculator.Subtract(firstNumber, secondNumber);
                    break;
                case "*":
                case "Multiply":
                    result = calculator.Multiply(firstNumber, secondNumber);
                    break;
                case "/":
                case "division":
                    result = calculator.Division(firstNumber, secondNumber);
                    break;
                case "^":
                case "Power":
                    result = calculator.Power(firstNumber, secondNumber);
                    break;
                case "%":
                case "Mod":
                    result = calculator.Mod(firstNumber, secondNumber);
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
                Console.WriteLine("Incorrect input !, try again");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }

            return tempInput;
        }
    }
}