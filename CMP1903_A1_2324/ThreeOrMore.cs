﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class ThreeOrMore
    {
        public Die dice1 = new Die();
        public Die dice2 = new Die();
        public Die dice3 = new Die();
        public Die dice4 = new Die();
        public Die dice5 = new Die();

        int Player1Score = 0;
        int Player2Score = 0;

        public void PlayThreeOrMore()
        {
            List<int> RollingDice = new List<int>();
            List<int> DupList = new List<int>();
            List<int> DupCountList = new List<int>();
            Console.WriteLine("Game Started");

            bool GameLoop = true;
            while (GameLoop == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Player 1s turn");
                Console.WriteLine("Press anything to roll");
                Console.WriteLine(" ");
                Console.ReadKey();
                int diceA = dice1.Roll();
                int diceB = dice2.Roll();
                int diceC = dice3.Roll();
                int diceD = dice4.Roll();
                int diceE = dice5.Roll();
                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");
                Console.WriteLine("Please select the dice you wish to re-roll.");
                Console.WriteLine("Example: '1'");
                Console.WriteLine("You will get to select more dice after if you want");
                Console.WriteLine("If you have selected all the dice you wish to reroll type 'done'");
                Console.WriteLine(" ");

                bool ChoiceLoop = true;
                RollingDice.Clear();

                while (ChoiceLoop == true)
                {

                    string DiceChoice = Console.ReadLine();
                    if (DiceChoice == "done")
                    {
                        ChoiceLoop = false;
                        Console.WriteLine(" ");
                    }
                    else if (DiceChoice == "1" | DiceChoice == "2" | DiceChoice == "3" | DiceChoice == "4" | DiceChoice == "5")
                    {
                        int NewDiceChoice = int.Parse(DiceChoice);
                        RollingDice.Add(NewDiceChoice);
                        Console.WriteLine("Anything else?");
                    }
                    else
                    {
                        Console.WriteLine("Valid inputs include: '1', '2', '3', '4', '5', 'done'");
                        Console.WriteLine("Please try again");
                        Console.WriteLine(" ");
                    }
                }

                if (RollingDice.Contains(1))
                {
                    diceA = dice1.Roll();
                }
                if (RollingDice.Contains(2))
                {
                    diceB = dice2.Roll();
                }
                if (RollingDice.Contains(3))
                {
                    diceC = dice3.Roll();
                }
                if (RollingDice.Contains(4))
                {
                    diceD = dice4.Roll();
                }
                if (RollingDice.Contains(5))
                {
                    diceE = dice5.Roll();
                }

                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");
                DupList.Clear();
                DupList.Add(diceA);
                DupList.Add(diceB);
                DupList.Add(diceC);
                DupList.Add(diceD);
                DupList.Add(diceE);
                int DupCount1 = DupList.Count(x => x == 1);
                int DupCount2 = DupList.Count(x => x == 2);
                int DupCount3 = DupList.Count(x => x == 3);
                int DupCount4 = DupList.Count(x => x == 4);
                int DupCount5 = DupList.Count(x => x == 5);
                int DupCount6 = DupList.Count(x => x == 6);
                DupCountList.Clear();
                DupCountList.Add(DupCount1);
                DupCountList.Add(DupCount2);
                DupCountList.Add(DupCount3);
                DupCountList.Add(DupCount4);
                DupCountList.Add(DupCount5);
                DupCountList.Add(DupCount6);
                int DupCount = DupCountList.Max();

                if (DupCount == 3)
                {
                    Player1Score = Player1Score + 3;
                    Console.WriteLine("Player 1 scored 3 points this turn");
                }
                else if (DupCount == 4)
                {
                    Player1Score = Player1Score + 6;
                    Console.WriteLine("Player 1 scored 6 points this turn");
                }
                else if (DupCount == 5)
                {
                    Player1Score = Player1Score + 12;
                    Console.WriteLine("Player 1 scored 12 points this turn");
                }
                else
                {
                    Console.WriteLine("Player 1 scored 0 points this turn");
                }


                //Player 2s turn


                Console.WriteLine("");
                Console.WriteLine("Player 2s turn");
                Console.WriteLine("Press anything to roll");
                Console.WriteLine(" ");
                Console.ReadKey();
                diceA = dice1.Roll();
                diceB = dice2.Roll();
                diceC = dice3.Roll();
                diceD = dice4.Roll();
                diceE = dice5.Roll();
                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");
                Console.WriteLine("Please select the dice you wish to re-roll.");
                Console.WriteLine("Example: '1'");
                Console.WriteLine("You will get to select more dice after if you want");
                Console.WriteLine("If you have selected all the dice you wish to reroll type 'done'");
                Console.WriteLine(" ");

                bool ChoiceLoop2 = true;
                RollingDice.Clear();

                while (ChoiceLoop2 == true)
                {

                    string DiceChoice = Console.ReadLine();
                    if (DiceChoice == "done")
                    {
                        ChoiceLoop2 = false;
                        Console.WriteLine(" ");
                    }
                    else if (DiceChoice == "1" | DiceChoice == "2" | DiceChoice == "3" | DiceChoice == "4" | DiceChoice == "5")
                    {
                        int NewDiceChoice = int.Parse(DiceChoice);
                        RollingDice.Add(NewDiceChoice);
                        Console.WriteLine("Anything else?");
                    }
                    else
                    {
                        Console.WriteLine("Valid inputs include: '1', '2', '3', '4', '5', 'done'");
                        Console.WriteLine("Please try again");
                        Console.WriteLine(" ");
                    }
                }

                if (RollingDice.Contains(1))
                {
                    diceA = dice1.Roll();
                }
                if (RollingDice.Contains(2))
                {
                    diceB = dice2.Roll();
                }
                if (RollingDice.Contains(3))
                {
                    diceC = dice3.Roll();
                }
                if (RollingDice.Contains(4))
                {
                    diceD = dice4.Roll();
                }
                if (RollingDice.Contains(5))
                {
                    diceE = dice5.Roll();
                }

                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");

                DupList.Clear();
                DupList.Add(diceA);
                DupList.Add(diceB);
                DupList.Add(diceC);
                DupList.Add(diceD);
                DupList.Add(diceE);
                DupCount1 = DupList.Count(x => x == 1);
                DupCount2 = DupList.Count(x => x == 2);
                DupCount3 = DupList.Count(x => x == 3);
                DupCount4 = DupList.Count(x => x == 4);
                DupCount5 = DupList.Count(x => x == 5);
                DupCount6 = DupList.Count(x => x == 6);
                DupCountList.Clear();
                DupCountList.Add(DupCount1);
                DupCountList.Add(DupCount2);
                DupCountList.Add(DupCount3);
                DupCountList.Add(DupCount4);
                DupCountList.Add(DupCount5);
                DupCountList.Add(DupCount6);
                DupCount = DupCountList.Max();

                if (DupCount == 3)
                {
                    Player2Score = Player2Score + 3;
                    Console.WriteLine("Player 2 scored 3 points this turn");
                }
                else if (DupCount == 4)
                {
                    Player2Score = Player2Score + 6;
                    Console.WriteLine("Player 2 scored 6 points this turn");
                }
                else if (DupCount == 5)
                {
                    Player2Score = Player2Score + 12;
                    Console.WriteLine("Player 2 scored 12 points this turn");
                }
                else
                {
                    Console.WriteLine("Player 2 scored 0 points this turn");
                }

                Console.WriteLine(" ");
                Console.WriteLine("Player 1s score: " + Player1Score);
                Console.WriteLine("Player 2s Score: " + Player2Score);
                Console.WriteLine(" ");

                if (Player1Score >= 20 | Player2Score >= 20)
                {
                    if (Player1Score > Player2Score)
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Player 1 Wins!!!");
                        Console.WriteLine("Press anything to close game");
                        Console.ReadKey();
                        GameLoop = false;
                    }
                    else if (Player1Score < Player2Score)
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Player 2 Wins!!!");
                        Console.WriteLine("Press anything to close game");
                        Console.ReadKey();
                        GameLoop = false;
                    }
                    else if (Player1Score == Player2Score)
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Draw!!!");
                        Console.WriteLine("Press anything to close game");
                        Console.ReadKey();
                        GameLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
            }
        }





        public void PlayThreeOrMorePVC()
        {
            List<int> RollingDice = new List<int>();
            List<int> DupList = new List<int>();
            List<int> DupCountList = new List<int>();
            List<int> ComputerChoice = new List<int>();
            List<int> ComputerChoice2 = new List<int>();
            Console.WriteLine("Game Started");

            bool GameLoop = true;
            while (GameLoop == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Players turn");
                Console.WriteLine("Press anything to roll");
                Console.WriteLine(" ");
                Console.ReadKey();
                int diceA = dice1.Roll();
                int diceB = dice2.Roll();
                int diceC = dice3.Roll();
                int diceD = dice4.Roll();
                int diceE = dice5.Roll();
                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");
                Console.WriteLine("Please select the dice you wish to re-roll.");
                Console.WriteLine("Example: '1'");
                Console.WriteLine("You will get to select more dice after if you want");
                Console.WriteLine("If you have selected all the dice you wish to reroll type 'done'");
                Console.WriteLine(" ");
                bool ChoiceLoop = true;
                RollingDice.Clear();

                while (ChoiceLoop == true)
                {

                    string DiceChoice = Console.ReadLine();
                    if (DiceChoice == "done")
                    {
                        ChoiceLoop = false;
                        Console.WriteLine(" ");
                    }
                    else if (DiceChoice == "1" | DiceChoice == "2" | DiceChoice == "3" | DiceChoice == "4" | DiceChoice == "5")
                    {
                        int NewDiceChoice = int.Parse(DiceChoice);
                        RollingDice.Add(NewDiceChoice);
                        Console.WriteLine("Anything else?");
                    }
                    else
                    {
                        Console.WriteLine("Valid inputs include: '1', '2', '3', '4', '5', 'done'");
                        Console.WriteLine("Please try again");
                        Console.WriteLine(" ");
                    }
                }

                if (RollingDice.Contains(1))
                {
                    diceA = dice1.Roll();
                }
                if (RollingDice.Contains(2))
                {
                    diceB = dice2.Roll();
                }
                if (RollingDice.Contains(3))
                {
                    diceC = dice3.Roll();
                }
                if (RollingDice.Contains(4))
                {
                    diceD = dice4.Roll();
                }
                if (RollingDice.Contains(5))
                {
                    diceE = dice5.Roll();
                }

                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");
                DupList.Clear();
                DupList.Add(diceA);
                DupList.Add(diceB);
                DupList.Add(diceC);
                DupList.Add(diceD);
                DupList.Add(diceE);
                int DupCount1 = DupList.Count(x => x == 1);
                int DupCount2 = DupList.Count(x => x == 2);
                int DupCount3 = DupList.Count(x => x == 3);
                int DupCount4 = DupList.Count(x => x == 4);
                int DupCount5 = DupList.Count(x => x == 5);
                int DupCount6 = DupList.Count(x => x == 6);
                DupCountList.Clear();
                DupCountList.Add(DupCount1);
                DupCountList.Add(DupCount2);
                DupCountList.Add(DupCount3);
                DupCountList.Add(DupCount4);
                DupCountList.Add(DupCount5);
                DupCountList.Add(DupCount6);
                int DupCount = DupCountList.Max();

                if (DupCount == 3)
                {
                    Player1Score = Player1Score + 3;
                    Console.WriteLine("Player 1 scored 3 points this turn");
                }
                else if (DupCount == 4)
                {
                    Player1Score = Player1Score + 6;
                    Console.WriteLine("Player 1 scored 6 points this turn");
                }
                else if (DupCount == 5)
                {
                    Player1Score = Player1Score + 12;
                    Console.WriteLine("Player 1 scored 12 points this turn");
                }
                else
                {
                    Console.WriteLine("Player 1 scored 0 points this turn");
                }

                //Computers turn

                Console.WriteLine("");
                Console.WriteLine("Computers turn");
                Console.WriteLine("Press anything to see roll");
                Console.WriteLine(" ");
                Console.ReadKey();
                diceA = dice1.Roll();
                diceB = dice2.Roll();
                diceC = dice3.Roll();
                diceD = dice4.Roll();
                diceE = dice5.Roll();
                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");
                Console.WriteLine("Re-rolling dice");
                Console.WriteLine(" ");
 
                ComputerChoice.Clear();
                ComputerChoice2.Clear();
                ComputerChoice.Add(diceA);
                ComputerChoice.Add(diceB);
                ComputerChoice.Add(diceC);
                ComputerChoice.Add(diceD);
                ComputerChoice.Add(diceE);
                int DiceNum1 = ComputerChoice.Count(i => i == 1);
                int DiceNum2 = ComputerChoice.Count(i => i == 2);
                int DiceNum3 = ComputerChoice.Count(i => i == 3);
                int DiceNum4 = ComputerChoice.Count(i => i == 4);
                int DiceNum5 = ComputerChoice.Count(i => i == 5);
                int DiceNum6 = ComputerChoice.Count(i => i == 6);
                ComputerChoice2.Add(DiceNum1);
                ComputerChoice2.Add(DiceNum2);
                ComputerChoice2.Add(DiceNum3);
                ComputerChoice2.Add(DiceNum4);
                ComputerChoice2.Add(DiceNum5);
                ComputerChoice2.Add(DiceNum6);
                ComputerChoice2.Remove(ComputerChoice2.Max());

                if (ComputerChoice2.Contains(DiceNum1))
                {
                    if (diceA == 1)
                    {
                        diceA = dice1.Roll();
                    }
                    if (diceB == 1)
                    {
                        diceB = dice2.Roll();
                    }
                    if (diceC == 1)
                    {
                        diceC = dice3.Roll();
                    }
                    if (diceD == 1)
                    {
                        diceD = dice4.Roll();
                    }
                    if (diceE == 1)
                    {
                        diceE = dice5.Roll();
                    }
                }

                if (ComputerChoice2.Contains(DiceNum2))
                {
                    if (diceA == 2)
                    {
                        diceA = dice1.Roll();
                    }
                    if (diceB == 2)
                    {
                        diceB = dice2.Roll();
                    }
                    if (diceC == 2)
                    {
                        diceC = dice3.Roll();
                    }
                    if (diceD == 2)
                    {
                        diceD = dice4.Roll();
                    }
                    if (diceE == 2)
                    {
                        diceE = dice5.Roll();
                    }
                }

                if (ComputerChoice2.Contains(DiceNum3))
                {
                    if (diceA == 3)
                    {
                        diceA = dice1.Roll();
                    }
                    if (diceB == 3)
                    {
                        diceB = dice2.Roll();
                    }
                    if (diceC == 3)
                    {
                        diceC = dice3.Roll();
                    }
                    if (diceD == 3)
                    {
                        diceD = dice4.Roll();
                    }
                    if (diceE == 3)
                    {
                        diceE = dice5.Roll();
                    }
                }

                if (ComputerChoice2.Contains(DiceNum4))
                {
                    if (diceA == 4)
                    {
                        diceA = dice1.Roll();
                    }
                    if (diceB == 4)
                    {
                        diceB = dice2.Roll();
                    }
                    if (diceC == 4)
                    {
                        diceC = dice3.Roll();
                    }
                    if (diceD == 4)
                    {
                        diceD = dice4.Roll();
                    }
                    if (diceE == 4)
                    {
                        diceE = dice5.Roll();
                    }
                }

                if (ComputerChoice2.Contains(DiceNum5))
                {
                    if (diceA == 5)
                    {
                        diceA = dice1.Roll();
                    }
                    if (diceB == 5)
                    {
                        diceB = dice2.Roll();
                    }
                    if (diceC == 5)
                    {
                        diceC = dice3.Roll();
                    }
                    if (diceD == 5)
                    {
                        diceD = dice4.Roll();
                    }
                    if (diceE == 5)
                    {
                        diceE = dice5.Roll();
                    }
                }

                if (ComputerChoice2.Contains(DiceNum6))
                {
                    if (diceA == 6)
                    {
                        diceA = dice1.Roll();
                    }
                    if (diceB == 6)
                    {
                        diceB = dice2.Roll();
                    }
                    if (diceC == 6)
                    {
                        diceC = dice3.Roll();
                    }
                    if (diceD == 6)
                    {
                        diceD = dice4.Roll();
                    }
                    if (diceE == 6)
                    {
                        diceE = dice5.Roll();
                    }
                }




                Console.WriteLine("Dice 1: " + diceA);
                Console.WriteLine("Dice 2: " + diceB);
                Console.WriteLine("Dice 3: " + diceC);
                Console.WriteLine("Dice 4: " + diceD);
                Console.WriteLine("Dice 5: " + diceE);
                Console.WriteLine(" ");
                DupList.Clear();
                DupList.Add(diceA);
                DupList.Add(diceB);
                DupList.Add(diceC);
                DupList.Add(diceD);
                DupList.Add(diceE);
                DupCount1 = DupList.Count(x => x == 1);
                DupCount2 = DupList.Count(x => x == 2);
                DupCount3 = DupList.Count(x => x == 3);
                DupCount4 = DupList.Count(x => x == 4);
                DupCount5 = DupList.Count(x => x == 5);
                DupCount6 = DupList.Count(x => x == 6);
                DupCountList.Clear();
                DupCountList.Add(DupCount1);
                DupCountList.Add(DupCount2);
                DupCountList.Add(DupCount3);
                DupCountList.Add(DupCount4);
                DupCountList.Add(DupCount5);
                DupCountList.Add(DupCount6);
                DupCount = DupCountList.Max();

                if (DupCount == 3)
                {
                    Player2Score = Player2Score + 3;
                    Console.WriteLine("Computer scored 3 points this turn");
                }
                else if (DupCount == 4)
                {
                    Player2Score = Player2Score + 6;
                    Console.WriteLine("Computer scored 6 points this turn");
                }
                else if (DupCount == 5)
                {
                    Player2Score = Player2Score + 12;
                    Console.WriteLine("Computer scored 12 points this turn");
                }
                else
                {
                    Console.WriteLine("Computer scored 0 points this turn");
                }

                Console.WriteLine(" ");
                Console.WriteLine("Player 1s score: " + Player1Score);
                Console.WriteLine("Player 2s Score: " + Player2Score);
                Console.WriteLine(" ");

                if (Player1Score >= 20 | Player2Score >= 20)
                {
                    if (Player1Score > Player2Score)
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Player 1 Wins!!!");
                        Console.WriteLine("Press anything to close game");
                        Console.ReadKey();
                        GameLoop = false;
                    }
                    else if (Player1Score < Player2Score)
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Computer Wins!!!");
                        Console.WriteLine("Press anything to close game");
                        Console.ReadKey();
                        GameLoop = false;
                    }
                    else if (Player1Score == Player2Score)
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Draw!!!");
                        Console.WriteLine("Press anything to close game");
                        Console.ReadKey();
                        GameLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
            }
        }
    }
}