using System;
using System.Collections.Generic;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play rock, paper, scissors! Would you like an easy or a hard opponent?");
            var playerType = Console.ReadLine();

            var playerOne = new Player1("Player One");
            var playerTwo = new Player2("Player Two");

            var userPlayer = new Player3("Main player");

            var answer = "y";
           
            if (playerType == "easy")
            {
            do
                {

                Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: ");

                var userInput = Console.ReadLine();
                

               Console.WriteLine($"Computer chooses {playerOne.GenerateRoshambo()}");
                if (userInput == "scissors")
                {
                    Console.WriteLine("Computer wins.");
                }
                if (userInput == "rock")
                {
                    Console.WriteLine("Draw");
                }
                if (userInput == "paper")
                {
                    Console.WriteLine("You win.");
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                }
                    Console.WriteLine("Try again?");
                answer = Console.ReadLine();
                } while (answer == "y");

            }
            if (playerType == "hard")
            {
                do
                {
                    Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: ");
                    var userInput = Console.ReadLine();
                    var computerInput = playerTwo.GenerateRoshambo();

                    Console.WriteLine($"Computer chooses {computerInput}");
                    Console.WriteLine("Try again?");

                    if ((userInput == "scissors" && computerInput == Roshambo.Rock) || (userInput == "rock" && computerInput == Roshambo.Paper) || (userInput == "paper" && computerInput == Roshambo.Scissors))
                    {
                        Console.WriteLine("Computer wins.");
                    }
                    if (computerInput.Equals(userInput))
                    {
                        Console.WriteLine("Draw");
                    }
                    if ((userInput == "rock" && computerInput == Roshambo.Scissors) || (userInput == "paper" && computerInput == Roshambo.Rock) || (userInput == "scissors" && computerInput == Roshambo.Paper))
                    {
                        Console.WriteLine("You win.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                    Console.WriteLine("Try again?");
                    answer = Console.ReadLine();
                } while (answer == "y");
           
           }
   
        }
    }
}