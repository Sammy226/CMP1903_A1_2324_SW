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
        int TotalScore2 = 0;

        public void PlaySevens()
        {
            bool SevensLoop1 = true;
            while (SevensLoop1 == true)
            {
                Console.WriteLine("Press anything to roll the dice");
                Console.ReadKey();
                int diceA = dice1.Roll();
                int diceB = dice2.Roll();
                if (diceA == diceB)
                {
                    int DiceScore = (diceA + diceB) * 2;
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
            }
            Console.WriteLine(" ");
            Console.WriteLine("Turn over, player 2s turn");

            bool SevensLoop2 = true;
            while (SevensLoop2 == true)
            {
                Console.WriteLine("Press anything to roll the dice");
                Console.ReadKey();
                int diceA = dice1.Roll();
                int diceB = dice2.Roll();
                if (diceA == diceB)
                {
                    int DiceScore = (diceA + diceB) * 2;
                    TotalScore2 = TotalScore2 + DiceScore;
                }
                else if (diceA + diceB == 7)
                {
                    SevensLoop2 = false;
                }
                else
                {
                    TotalScore2 = diceA + diceB;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Dice 1 rolled: " + diceA);
                Console.WriteLine("Dice 2 rolled: " + diceB);
                Console.WriteLine("The total adds up to: " + TotalScore2);
                Console.WriteLine(" ");
            }
            if (TotalScore1 > TotalScore2)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Player 1 Wins!!!");
            }
            else if (TotalScore2 > TotalScore1)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Player 2 Wins!!!");
            }
            else
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Draw");
            }

        }

    }
}
