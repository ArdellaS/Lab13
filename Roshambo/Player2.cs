using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Player2 : Player
    {
        private static string name;
        private static string roshamboValue;

        public Player2(string PlayerTwo)
            : base(name)
        {
            Name = PlayerTwo;
            
        }
        public override Roshambo GenerateRoshambo()
        {
            Random randomRoshamboValue = new Random();
            return (Roshambo)randomRoshamboValue.Next(0,3);
        }

    }

}

