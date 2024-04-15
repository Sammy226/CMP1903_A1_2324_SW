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
        Statistics Players = new Statistics();
        public void SelectGame()
        {
            Console.WriteLine("Which game would you like to play");
            Console.WriteLine("Enter 1 to play Sevens Out");
            Console.WriteLine("Enter 2 to play Three Or More");
            Console.WriteLine(" ");
            bool GameLoop = true;
            while (GameLoop == true)
            {
                try // will check the code inside for exceptions thrown
                {
                    int GameChoice = Convert.ToInt32(Console.ReadLine()); // takes an input from user and converts it to an int
                    if (GameChoice == 1) // if the user enters a 1 the program starts Sevens Out
                    {
                        Sevens.PlaySevens();
                        GameLoop = false;
                    }
                    else if (GameChoice == 2) // if the user enters a 2 the program asks them to choose between playing against another player or a computer
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
                                Players.PlayerCount(2);
                                Console.WriteLine("Players: " + Players.PlayerCount(0));
                                Console.WriteLine(" ");
                                ThreeTest.TestThreeOrMore();
                            }
                            else if (VSchoice == "2")
                            {
                                VSoptions = false;
                                Players.PlayerCount(1);
                                Console.WriteLine("Players: " + Players.PlayerCount(0));
                                Console.WriteLine(" ");
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
                catch (FormatException) // catches an exception if the user inputs anything other then an int
                {
                    Console.WriteLine("Please enter either '1' or '2'");
                }
            }
        }
    }
}
