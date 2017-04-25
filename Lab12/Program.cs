using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            string rock = "r";
            string paper =  "p";
            string scissors = "s";

            HumanPlayer user = new HumanPlayer();
            RockPlayer rck = new RockPlayer();
            RandomPlayer rndm = new RandomPlayer();


            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();


            Console.WriteLine($"{userName}: {user.GetRoshambo()}");
            Console.WriteLine($"Rock player chose {rck.GetRoshambo()}");
            


        }
    }
}
