using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


        
            
                Console.WriteLine("Shape Area Calculator");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Square");
                Console.Write("Choose a shape (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                double area = 0;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        area = Math.PI * radius * radius;
                        break;
                    case 2:
                        Console.Write("Enter the length: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the width: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        area = length * width;
                        break;
                    case 3:
                        Console.Write("Enter the base: ");
                        double baseLength = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        area = 0.5 * baseLength * height;
                        break;
                    case 4:
                        Console.Write("Enter the side length: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        area = side * side;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                Console.WriteLine("\nThe area is: " + area);
            }
        }

    }


