using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class SevensOut
    {
        int diceA = 0;
        int diceB = 0;

        public void PlaySevens() // starts the sevens out game
        {
            Die dice1 = new Die();
            Die dice2 = new Die();
            Testing TestS = new Testing();
            PlayerScores Score = new PlayerScores();
            bool SevensLoop1 = true;
            while (SevensLoop1 == true)
            {
                int DiceTotal = 0;
                int DiceScore = 0;
                Console.WriteLine("Press anything to roll the dice");
                Console.ReadKey();
                diceA = dice1.Roll(); // rolls both dice
                diceB = dice2.Roll();
                if (diceA == diceB) // checks for double and doubles score if so
                {
                    DiceTotal = diceA + diceB;
                    DiceScore = DiceTotal * 2;
                    Score.SevensOutScore1(DiceScore);
                    
                }
                else if (TestS.TestSevensOut(diceA, diceB) == true) // checks to see if dice total is 7
                {
                    DiceTotal = diceA + diceB;
                    SevensLoop1 = false; // ends player 1s turn
                }
                else // adds dice total to player score
                {
                    DiceTotal = diceA + diceB;
                    Score.SevensOutScore1(DiceTotal);
                }
                Console.WriteLine(" "); // displays dice numbers, dice total and player score
                Console.WriteLine("Dice 1 rolled: " + diceA);
                Console.WriteLine("Dice 2 rolled: " + diceB);
                Console.WriteLine("The Dice Total is: " + DiceTotal);
                Console.WriteLine("Player 1s score is: " + Score.SevensOutScore1(0));
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
                    Score.SevenOutScore2(DiceScore);
                }
                else if (TestS.TestSevensOut(diceA, diceB) == true)
                {
                    DiceTotal = diceA + diceB;
                    SevensLoop2 = false;
                }
                else
                {
                    DiceTotal = diceA + diceB;
                    Score.SevenOutScore2(DiceTotal);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Dice 1 rolled: " + diceA);
                Console.WriteLine("Dice 2 rolled: " + diceB);
                Console.WriteLine("The Dice Total is: " + DiceTotal);
                Console.WriteLine("Player 2s score is: " + Score.SevenOutScore2(0));
                Console.WriteLine(" ");
                diceA = 0;
                diceB = 0;
            }

            int P1 = Score.SevensOutScore1(0);
            int P2 = Score.SevenOutScore2(0);
            if (P1 > P2) // check who has the biggest score and announces the winner
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Player 1 Wins!!!");
                Console.WriteLine("Press any key to close game");
                Console.ReadKey();
            }
            else if (P2 > P1)
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

        public void SevensOutRules() // displays the sevens out rules
        {
            Console.WriteLine(" ");
            Console.WriteLine("In Sevens Out you will take turns rolling two dice");
            Console.WriteLine("The total value of those dice will be added to your scores");
            Console.WriteLine("If you roll a double, your score will be doubled for that turn");
            Console.WriteLine("If you roll a 7 then your turn ends and its the other players turn to roll the dice");
            Console.WriteLine("Also seven is not added to your score.");
            Console.WriteLine("The game ends when both players have rolled a 7");
            Console.WriteLine("The winner is the one with the biggest score at the end");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

    }
}
