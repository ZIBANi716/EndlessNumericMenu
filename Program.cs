using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessNumericMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isrunning = true;
            while (isrunning == true)
            {
                Console.WriteLine("Enter a number to check");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Error: not a number!");
                    continue;
                }
                if (number < 0)
                {
                    Console.WriteLine("The number is negative!");
                }
                else if (number > 0)
                {
                    Console.WriteLine("The number is positive!");
                }
                else
                {
                    Console.WriteLine("Zero value!");
                }
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even!");
                }
                else
                {
                    Console.WriteLine("The number is odd!");
                }
                Console.WriteLine("Do you want to continue? y/n?");
                string input = Console.ReadLine();
                while (input != "y" && input != "n")
                {
                    Console.WriteLine("Invalid input! Enter y or n!");
                    input = Console.ReadLine();
                }
                if (input == "n")
                {
                    isrunning = false;
                }
            }











        }
    }
}
