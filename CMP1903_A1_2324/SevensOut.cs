using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class SevensOut
    {
        public Die dice1 = new Die();
        public Die dice2 = new Die();

        int TotalScore1 = 0;

        public int PlaySevens()
        {
            bool SevensLoop1 = true;
            while (SevensLoop1 == true)
            {
                Console.ReadKey();
                int diceA = dice1.Roll();
                int diceB = dice2.Roll();
                if (diceA == diceB)
                {
                    int DiceScore = diceA + diceB * 2;
                       TotalScore1 = TotalScore1 + DiceScore;
                }
                else if (diceA + diceB == 7)
                {
                    SevensLoop1 = false;
                }
                else
                {
                    TotalScore1 = diceA + diceB;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Dice 1 rolled: " + diceA);
                Console.WriteLine("Dice 2 rolled: " + diceB);
                Console.WriteLine("The total adds up to: " + TotalScore1);
                Console.WriteLine(" ");
                Console.WriteLine("Press anything to roll again");
            }

        }
    }
}
