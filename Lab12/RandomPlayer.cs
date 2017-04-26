using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer: Player
    {
        public override string GetRoshambo()
        {
            Random rPS = new Random();
            int outcome = rPS.Next(1, 4);
            if (outcome == 1)
                return "Rock";
            else if (outcome == 2)
                return "Paper";
            else 
                return "Scissors";

        }


    }
}
