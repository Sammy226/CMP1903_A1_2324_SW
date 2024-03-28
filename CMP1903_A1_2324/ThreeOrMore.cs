using System;
using System.Collections.Generic;
using System.Linq;
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

        
        public void PlayThreeOrMore()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player 1 starts");
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
            bool ChoiceLoop = true;
            List<int> RollingDice = new List<int>();
            while (ChoiceLoop == true)
            {
                
                string DiceChoice = Console.ReadLine();
                if (DiceChoice == "done")
                {
                    ChoiceLoop = false;
                }
                else
                {
                    int NewDiceChoice = int.Parse(DiceChoice);
                    RollingDice.Add(NewDiceChoice);
                }
            }    
        }
    }
}
