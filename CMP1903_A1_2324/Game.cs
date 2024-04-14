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
        Testing ThreeTest = new Testing();
        public void SelectGame()
        {
            Console.WriteLine("Which game would you like to play");
            Console.WriteLine("Enter 1 to play Sevens Out");
            Console.WriteLine("Enter 2 to play Three Or More");
            Console.WriteLine(" ");
            bool GameLoop = true;
            while (GameLoop == true)
            {
                try
                {
                    int GameChoice = Convert.ToInt32(Console.ReadLine());
                    if (GameChoice == 1)
                    {
                        Sevens.PlaySevens();
                        GameLoop = false;
                    }
                    else if (GameChoice == 2)
                    {
                        GameLoop = false;
                        Console.WriteLine("Do you want to play Three Or More against another player or a computer");
                        Console.WriteLine("Press 1 to play VS a player, press 2 to play VS the computer");
                        bool VSoptions = true;
                        while (VSoptions == true)
                        {
                            string VSchoice = Console.ReadLine();
                            if (VSchoice == "1")
                            {
                                VSoptions = false;
                                ThreeTest.TestThreeOrMore();
                            }
                            else if (VSchoice == "2")
                            {
                                VSoptions = false;
                                ThreeTest.TestThreeOrMorePVC();
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
                catch (FormatException)
                {
                    Console.WriteLine("Please enter either '1' or '2'");
                }
            }
        }
    }
}
