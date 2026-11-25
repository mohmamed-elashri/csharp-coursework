using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.Write("Enter first number: ");
            double num1 = GetValidNumber();

            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second number: ");
            double num2 = GetValidNumber();

            double result;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }

        static double GetValidNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            return number;

        }
    }
}
