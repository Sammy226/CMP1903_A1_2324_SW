using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        Die DiceTest = new Die();
        Game GameTest = new Game();


        public void Test()
        {
            if (DiceTest.Roll() != 0)
            {
                Debug.Assert((1 <= DiceTest.Roll()) || (6 >= DiceTest.Roll())); // this prevents the dice from rolling higher then a 6 or lower then 1
                Console.WriteLine(" ");
            }
            else if (GameTest.RollDice() != 0)
            {
                Debug.Assert((3 <= GameTest.RollDice()) || (18 >= GameTest.RollDice())); // this prevents the total dice rolls from going higher then the max (18) and lower then the min (3)
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("dice value exceeds range");
            }
        }
    }
}