using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    abstract class Player 
    {
        public string Name { get; set; }
       

        public Player (string name)
        {
            Name = name;
            
        }
        public abstract Roshambo GenerateRoshambo();
        
    }

}
