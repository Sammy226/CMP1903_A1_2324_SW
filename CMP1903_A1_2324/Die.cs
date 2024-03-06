using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int DiceNum;

        static Random rolling = new Random();
        
        
        public int Roll()
        {
            DiceNum = 0; // this resets the dice value if the user re-rolls it.
            DiceNum = rolling.Next(1,7); // this picks a random number between 1 and 6 and stores it in "DiceNum"
            return DiceNum;
        }
    }
}
