using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game PlayGame = new Game();
            Testing TestGame = new Testing();


            bool loop = true;
            PlayGame.RollDice();
            TestGame.Test();
            while (loop == true) // this while loop will allow the user to reroll the dice should they wish to
            {
                string UserInput = Console.ReadLine();
                if (UserInput == "re-roll")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Re-rolling dice...");
                    Console.WriteLine(" ");
                    PlayGame.RollDice();
                    TestGame.Test();
                }
                else if (UserInput == "end")
                {
                    loop = false;
                    Console.WriteLine(" ");
                    Console.WriteLine("Game ended, press any key to close the window");
                    break;
                }
                else //this makes sure the program doesnt break if the user enter a string that isnt recognised
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Only 're-roll' and 'end' are accepted inputs");
                }
            }
            Console.ReadKey();
        }
    }
}