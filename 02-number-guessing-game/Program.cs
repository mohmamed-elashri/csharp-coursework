using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int guess;
            int attempts = 0;
            bool correctGuess = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");

            while (!correctGuess)
            {
                Console.Write("Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    correctGuess = true;
                }
            }
                Console.WriteLine("Thank you for playing!");


            }
        }
    }

