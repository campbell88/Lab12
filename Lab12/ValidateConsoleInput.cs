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
    }
}
