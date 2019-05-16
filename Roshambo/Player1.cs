using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Player1 : Player
    {
        private static string name;
       

        public Player1(string PlayerOne)  
            :base(name)
        {
            Name = PlayerOne;
            
        }
        public override Roshambo GenerateRoshambo()
        {
            Roshambo rock = Roshambo.Rock;
            return rock;
        }
    }
}
