using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        
            
class GradeCalculator
        {
            static void Main()
            {
                Console.Write("Enter your score: ");
                double score = Convert.ToDouble(Console.ReadLine());
                string grade;

                if (score >= 90)
                    grade = "Excellent (A)";
                else if (score >= 80)
                    grade = "Very Good (B)";
                else if (score >= 70)
                    grade = "Good (C)";
                else if (score >= 60)
                    grade = "Pass (D)";
                else
                    grade = "Fail (F)";

                Console.WriteLine("\nYour Grade: " + grade);
            }
        }


    }
}

