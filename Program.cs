using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, squared, cubed;
            string restart, name;

            Console.WriteLine("Welcome to learn your squares and cubes! Press enter to continue"); 
            Console.ReadLine();
            Console.WriteLine("Plese enter your first name: ");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine(name + ", please enter an integer");
                num1 = Int32.Parse(Console.ReadLine());

                for (int i = 1; i <= num1; i++)

                {
                    squared = i * i;
                    cubed = i * i * i;

                    Console.WriteLine("Your number squared is: {0}", squared);
                    Console.WriteLine("Your number cubed is: {0}", cubed);

                }
                Console.WriteLine(name + ", would you like to restart? (Y or N)");


                restart = Console.ReadLine();

            } while (restart.ToLower() == "y");

        }
    }
}