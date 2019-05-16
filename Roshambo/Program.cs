using System;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play rock, paper, scissors! Would you like an easy or a difficult opponent?");
            var playerType = Console.ReadLine();

            var playerOne = new Player1("Player One");
            var playertwo = new Player2("Player Two");

            var answer = "y";
            do
            {
                if (playerType == "Easy")
                {
                    Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: ");
                    string userInput = Console.ReadLine();
                }
                Console.WriteLine(playerOne.GenerateRoshambo());
                Console.WriteLine(playertwo.GenerateRoshambo());


                Console.WriteLine("Try again?");
                answer = Console.ReadLine();
            } while (answer == "y");
            

            
            //if (playerType == "easy")

            //{
            //    do
            //    {
            //        Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: ");
            //        string userInput = Console.ReadLine();
                    
                    
            //    } while (true);
            //    else
            //    {
            //        Console.WriteLine("invalid election");
            //    }
            //}

        }
    }
}
