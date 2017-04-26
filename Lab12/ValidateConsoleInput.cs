using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class ValidateConsoleInput
    {
        // Method to Get Valid String
        public static string GetValidStringPlayerChoice()
        {
            string[] validOptions = { "r", "j"};
            string Input = Console.ReadLine().ToLower();

            // Validate Input
            while ((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input) || !(validOptions.Contains(Input))))
            {
                Console.Write("Error: Please enter only the following: R or J: \n");
                Input = Console.ReadLine().ToLower();

            }
            return Input;
        }

        public static string GetValidStringRPS()
        {
            string[] validOptions = { "r", "p", "s" };
            string Input = Console.ReadLine().ToLower();

            // Validate Input
            while ((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input) || !(validOptions.Contains(Input))))
            {
                Console.Write("Error: Please enter only the following: R / P / S: ");
                Input = Console.ReadLine().ToLower();

            }
            return Input;
        }

        public static bool Continue()
        {
            Console.WriteLine("Play Again? (y/n)");

            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                Matrix.Run();

                return false;
                 
            }
            else if (input.ToLower() == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Continue();
                return true;
            }

        }
    }
}
