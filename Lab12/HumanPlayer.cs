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
            Console.WriteLine("Rock, Paper or Scissors? Enter R/P/S: ");
            string input = Console.ReadLine();
            return input;
        }

    }
}
