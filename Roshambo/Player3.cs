using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Player3 : Player
    {
        public Player3(string name) : base(name)
        {
            name = Name;
           
        }

        public override Roshambo GenerateRoshambo()
        {
            Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: ");
            Roshambo userInput = Enum.Parse<Roshambo>(Console.ReadLine());
            return userInput;
        }
    }
}
