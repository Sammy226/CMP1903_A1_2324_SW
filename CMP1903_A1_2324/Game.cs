using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public Die dice1 = new Die();
        public Die dice2 = new Die();
        public Die dice3 = new Die();

        //this creates three dice objects

        int DiceTotal = 0; //"DiceTotal" is a variable that will store the dices totals but not reset if the user re-rolls.

        public int RollDice()
        {
            
            int diceA = dice1.Roll();// this generates a random number between 1 - 6 and stores it in diceA, diceB and diceC
            int diceB = dice2.Roll();
            int diceC = dice3.Roll();
            int DiceSum = diceA + diceB + diceC; // this will store the three dices total
            DiceTotal = DiceTotal + diceA + diceB + diceC;
            Console.WriteLine("The first dice rolled a " + diceA);
            Console.WriteLine("the secind dice rolled a " + diceB);
            Console.WriteLine("The third dice rolled a " + diceC);
            Console.WriteLine(" ");
            Console.WriteLine("The sum of the three dice is " + DiceSum);
            Console.WriteLine("The total of every dice rolled is " + DiceTotal);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("To re-roll the dice type 're-roll'");
            Console.WriteLine("To close the game type 'end'");
            Console.WriteLine("Any other user input will not be accepted");
            return DiceSum;
        }
    }
}
