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
        int diceA = 0;
        int diceB = 0;

        public void PlaySevens()
        {
            bool SevensLoop1 = true;
            while (SevensLoop1 == true)
            {
                int DiceTotal = 0;
                int DiceScore = 0;
                Console.WriteLine("Press anything to roll the dice");
                Console.ReadKey();
                diceA = dice1.Roll();
                diceB = dice2.Roll();
                if (diceA == diceB)
                {
                    DiceScore = (diceA + diceB) * 2;
                    DiceTotal = diceA + diceB;
                    TotalScore1 = TotalScore1 + DiceScore;
                }
                else if (diceA + diceB == 7)
                {
                    DiceTotal = diceA + diceB;
                    SevensLoop1 = false;
                }
                else
                {
                    DiceTotal = diceA + diceB;
                    TotalScore1 =  TotalScore1 + diceA + diceB;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Dice 1 rolled: " + diceA);
                Console.WriteLine("Dice 2 rolled: " + diceB);
                Console.WriteLine("The Dice Total is: " + DiceTotal);
                Console.WriteLine("Player 1s score is: " + TotalScore1);
                Console.WriteLine(" ");
                diceA = 0;
                diceB = 0;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Turn over, player 2s turn");

            bool SevensLoop2 = true;
            while (SevensLoop2 == true)
            {
                int DiceTotal = 0;
                int DiceScore = 0;
                Console.WriteLine("Press anything to roll the dice");
                Console.ReadKey();
                diceA = dice1.Roll();
                diceB = dice2.Roll();
                if (diceA == diceB)
                {
                    DiceScore = (diceA + diceB) * 2;
                    DiceTotal = diceA + diceB;
                    TotalScore2 = TotalScore2 + DiceScore;
                }
                else if (diceA + diceB == 7)
                {
                    DiceTotal = diceA + diceB;
                    SevensLoop2 = false;
                }
                else
                {
                    DiceTotal = diceA + diceB;
                    TotalScore2 = TotalScore2 + diceA + diceB;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Dice 1 rolled: " + diceA);
                Console.WriteLine("Dice 2 rolled: " + diceB);
                Console.WriteLine("The Dice Total is: " + DiceTotal);
                Console.WriteLine("Player 2s score is: " + TotalScore2);
                Console.WriteLine(" ");
                diceA = 0;
                diceB = 0;
            }
            if (TotalScore1 > TotalScore2)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Player 1 Wins!!!");
                Console.WriteLine("Press any key to close game");
                Console.ReadKey();
            }
            else if (TotalScore2 > TotalScore1)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Player 2 Wins!!!");
                Console.WriteLine("Press any key to close game");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Draw");
                Console.WriteLine("Press any key to close game");
                Console.ReadKey();
            }

        }

    }
}
