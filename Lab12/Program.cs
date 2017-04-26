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
            do
            {

                string output1 = "";
                string output2 = "";
                string choice;
                HumanPlayer user = new HumanPlayer();
                RockPlayer rck = new RockPlayer();
                RandomPlayer rndm = new RandomPlayer();


                Console.WriteLine("Welcome to Rock Paper Scissors! Still in Beta Mode!\n");
                Console.WriteLine("Enter your name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("\nWho would you like to play? Rocky or Jokester?");
                Console.WriteLine("Enter R or J: ");
                choice = ValidateConsoleInput.GetValidStringPlayerChoice();

                if (choice == "r")
                {
                    output1 = user.GetRoshambo(); //assigning a value from the human player method
                    output2 = rck.GetRoshambo();
                    Console.WriteLine($"{userName}: {output1}");
                    Console.WriteLine($"Rocky: {output2}");
                    if (output1 == "Paper")
                        Console.WriteLine("You WIN! Hooray!");
                    if (output1 == "Scissors")
                        Console.WriteLine("You LOSE! BA HA HA");
                    if (output1 == "Rock")
                        Console.WriteLine("DRAW!");
                }


                if (choice == "j")
                {
                    output1 = user.GetRoshambo();
                    output2 = rndm.GetRoshambo();
                    Console.WriteLine($"{userName}: {output1}");
                    Console.WriteLine($"Jokester: {output2}");
                    if (output1 == output2)
                        Console.WriteLine("DRAW!");
                    else if (((output1 == "Paper") && (output2 == "Rock")) || ((output1 == "Rock") && (output2 == "Scissors") || ((output1 == "Scissors") && (output2 == "Paper"))))
                        Console.WriteLine("You WIN! Hooray!");
                    else
                        Console.WriteLine("You LOSE! BA HA HA");

                }
            } while (ValidateConsoleInput.Continue());















            //Console.WriteLine($"{userName}: {user.GetRoshambo()}");
            //Console.WriteLine($"Rock player: {rck.GetRoshambo()}");
            //Console.WriteLine($"Random player: {rndm.GetRoshambo()}");
            


        }
    }
}
