using System;
using System.IO.Ports;
using System.Linq;
using System.Net.Mime;
using Calculator;
using NUnit.Framework.Constraints;

namespace Calculator2
{
    public class Program
    {
        private static readonly string[] Operations = {"+", "-", "*", "/", "^", "%", "STOP", "C"};

        static void Main(string[] args)
        {
            FuncsForCalc calculator = new FuncsForCalc();
            double result = 0;
            double firstNumber = SetNumber("Type your first number : ");
           
            string stringOperation = SetOperation("Enter the operation: + (Add), - (Subtract), * (Multiply), / (Division), % (Mod) or ^ (Power):");

            double secondNumber = SetNumber("Type your second number: ");

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
            calcLoop(calculator);
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

        private static void calcLoop(FuncsForCalc calculator)
        {

            string stringOperation = SetOperation("Enter the operation, C to reset sum or stop by typing STOP: + (Add), - (Subtract), * (Multiply), / (Division), % (Mod) or ^ (Power):");
            if (stringOperation == "STOP")
                System.Environment.Exit(1);
            else if (stringOperation == "C")
            {
                calculator.resetSum();
                Main(null);
            }

            Console.Write("Enter a new number: ");
            string newNumber = Console.ReadLine();
          
            double result = 0;
            
            switch (stringOperation)
                {
                    case "+":
                    case "Add":
                        result = calculator.Add(calculator.getSum(), Double.Parse(newNumber));
                        break;
                    case "-":
                    case "Subtract":
                        result = calculator.Subtract(calculator.getSum(), Double.Parse(newNumber));
                        break;
                    case "*":
                    case "Multiply":
                        result = calculator.Multiply(calculator.getSum(), Double.Parse(newNumber));
                        break;
                    case "/":
                    case "division":
                        result = calculator.Division(calculator.getSum(), Double.Parse(newNumber));
                        break;
                    case "^":
                    case "Power":
                        result = calculator.Power(calculator.getSum(), Double.Parse(newNumber));
                        break;
                    case "%":
                    case "Mod":
                        result = calculator.Mod(calculator.getSum(), Double.Parse(newNumber));
                        break;
                }

                Console.WriteLine("Result: " + result);
                
                calcLoop(calculator);
        }        
    }
}