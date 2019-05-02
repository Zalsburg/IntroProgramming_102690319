using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            //Setting up list
            var rps = new List<string> {"rock", "paper", "scissors"};
            var winner = new List<string>();
            
            //Introducing user to the game
            Console.WriteLine("Hello there");
            Console.WriteLine("Let's play a game of Paper, Scissors, Rock.");
            Console.WriteLine("Best of three for three rounds... Let's see who will win: Person or Machine");
            Console.WriteLine();


            //making the round
            int usercount = 0;
            int compcount = 0;
            while (usercount < 2 && compcount < 2) {
                //randomising computer's response (Reference 1)
                var random = new Random();
                int index = random.Next(rps.Count);

                Console.WriteLine("Are you ready?");
                Console.WriteLine("Paper... Scissors... Rock!");
                Console.Write("Your turn: ");
                string useranswer = Console.ReadLine();
                Console.WriteLine("I say... " + rps[index]);
                Console.WriteLine();
                
                //calculating who wins

                //if the answer is the same:
                if (useranswer == rps[index])
                {
                    Console.WriteLine("Whoops! Try again!");
                }
                //if the answers are not the same:
                else {
                    //if the user answers rock...
                    if (useranswer == "rock" && rps[index] == "scissors") {
                        Console.WriteLine("You win!");
                        winner.Add("user");
                        usercount++;
                    }
                    else if (useranswer == "rock" && rps[index] == "paper") {
                        Console.WriteLine("I win!");
                        winner.Add("computer");
                        compcount++;
                    }
                    else if (useranswer == "scissors" && rps[index] == "rock") {
                        Console.WriteLine("I win!");
                        winner.Add("computer");
                        compcount++;
                    }
                    else if (useranswer == "scissors" && rps[index] == "paper") {
                        Console.WriteLine("You win!");
                        winner.Add("user");
                        usercount++;
                    }
                    else if (useranswer == "paper" && rps[index] == "rock") {
                        Console.WriteLine("You win!");
                        winner.Add("user");
                        usercount++;
                    }
                    else if (useranswer == "paper" && rps[index] == "scissors") {
                        Console.WriteLine("I win!");
                        winner.Add("computer");
                        compcount++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Who won?");
            winner.ForEach(Console.WriteLine);
            Console.WriteLine();
            if (usercount > compcount) {
                Console.WriteLine("You won the round!");
            }
            else {
                Console.WriteLine("I won the round!");
            }

            Console.ReadKey(true);

            //References:
            //1. https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
        }
    }
}
