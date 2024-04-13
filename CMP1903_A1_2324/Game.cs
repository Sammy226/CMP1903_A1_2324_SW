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
        SevensOut Sevens = new SevensOut();
        ThreeOrMore Three = new ThreeOrMore();
        public void SelectGame()
        {
            Console.WriteLine("Which game would you like to play");
            Console.WriteLine("Enter 1 to play Sevens Out");
            Console.WriteLine("Enter 2 to play Three Or More");
            Console.WriteLine(" ");
            bool GameStartLoop = true;
            while (GameStartLoop == true)
            {
                string GameChoice = Console.ReadLine();
                if (GameChoice == "1")
                {
                    Sevens.PlaySevens();
                    GameStartLoop = false;
                }
                else if (GameChoice == "2")
                {
                    GameStartLoop = false;
                    Console.WriteLine("Do you want to play Three Or More against another player or a computer");
                    Console.WriteLine("Press 1 to play VS a player, press 2 to play VS the computer");
                    bool VSoptions = true;
                    while (VSoptions == true)
                    {
                        string VSchoice = Console.ReadLine();
                        if (VSchoice == "1")
                        {
                            VSoptions = false;
                            Three.PlayThreeOrMore();
                        }
                        else if (VSchoice == "2")
                        {
                            VSoptions = false;
                            Three.PlayThreeOrMorePVC();
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Only '1' and '2' are accepted inputs");
                            Console.WriteLine(" ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Only '1' and '2' are accepted inputs");
                }
            }

        }
    }
}
