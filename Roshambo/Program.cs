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
            playerType.ToLower();

            var playerOne = new Player1("Player One");
            var playerTwo = new Player2("Player Two");
           var userPlayer = new Player3("Main player");

            var answer = "y";
           
            if (playerType.Equals("easy", StringComparison.OrdinalIgnoreCase))
            {
            do
                {

                Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: ");

                var userInput = Console.ReadLine();
                

               Console.WriteLine($"Computer chooses {playerOne.GenerateRoshambo()}");
                if (userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Computer wins.");
                }
                if (userInput.Equals("rock", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Draw");
                }
                if (userInput.Equals("paper", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You win.");
                }
               
                Console.WriteLine("Try again?");
                answer = Console.ReadLine();
                } while (answer == "y");

            }
            if (playerType.Equals("hard", StringComparison.OrdinalIgnoreCase))
            {
                do
                {
                    Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: ");
                    var userInput = Console.ReadLine();
                    var computerInput = playerTwo.GenerateRoshambo();
                    
                    Console.WriteLine($"You chose {userInput} and Computer chooses {computerInput}");
                    

                    if ((userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Rock) || ((userInput.Equals("rock", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Paper)) || ((userInput.Equals("paper", StringComparison.OrdinalIgnoreCase)) && computerInput == Roshambo.Scissors))
                    {
                        Console.WriteLine("Computer wins.");
                    }
                    if (computerInput.Equals(userInput))
                    {
                        Console.WriteLine("Draw");
                    }
                    if ((userInput.Equals("rock", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Scissors) || ((userInput.Equals("paper", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Rock)) || ((userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase)) && computerInput == Roshambo.Paper))
                    {
                        Console.WriteLine("You win.");
                    }
                     Console.WriteLine("Try again?");
                    answer = Console.ReadLine();
                } while (answer == "y");
           
           }
   
        }
    }
}