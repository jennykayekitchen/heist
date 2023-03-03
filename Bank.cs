using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    public class Bank
    {

        public int DifficultyLevel { get; set; }
        
        public Bank(int difficultyLevel)
        {
            DifficultyLevel = difficultyLevel;
        }

        public Bank()
        {
        }
    }
}