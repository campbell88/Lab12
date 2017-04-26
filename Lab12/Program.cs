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

            string output1 = "";
            string output2 = "";
            string choice;
            HumanPlayer user = new HumanPlayer();
            RockPlayer rck = new RockPlayer();
            RandomPlayer rndm = new RandomPlayer();


            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("\nWho would you like to play? Rocky or Jokester?");
            Console.WriteLine("Enter R or J: ");
            choice = Console.ReadLine();

            if (choice == "r")
            {
                output1 = user.GetRoshambo(); //assigning a value from the human player method, now need to do method or if else statement for who wins
                output2 = rck.GetRoshambo();
                Console.WriteLine($"{userName}: {output1}");
                Console.WriteLine($"Rocky: {output2}");
            }
            if (choice == "j")
            {
                output1 = user.GetRoshambo();
                output2 = rndm.GetRoshambo();
            }















            //Console.WriteLine($"{userName}: {user.GetRoshambo()}");
            //Console.WriteLine($"Rock player: {rck.GetRoshambo()}");
            //Console.WriteLine($"Random player: {rndm.GetRoshambo()}");
            


        }
    }
}
