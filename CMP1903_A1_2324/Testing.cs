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
        int TestDice = 0;
        int TestGame = 0;
        public bool Test()
        {
            TestDice = DiceTest.Roll();
            TestGame = GameTest.RollDice();
            if (TestDice != 0)
            {
                Debug.Assert((1 <= TestDice) && (6 >= TestDice));
                return true;
            }
            else if (TestGame != 0)
            {
                Debug.Assert((1 <= TestGame) && (18 >= TestGame));
                    return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
    }
}
