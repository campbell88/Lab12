using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer: Player
    {
        public override string GetRoshambo()
        {
            Console.WriteLine("Okay, Rock, Paper or Scissors? Enter R/P/S: ");
            string input = Console.ReadLine();
            if (input == "r")
                return "rock";
            else if (input == "p")
                return "paper";
            else
                return "scissors";

        }

    }
}
