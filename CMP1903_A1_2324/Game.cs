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
            string GameChoice = Console.ReadLine();
            if (GameChoice == "1")
            {
                Sevens.PlaySevens();
            }
            else if (GameChoice == "2")
            {
                Three.PlayThreeOrMore();
            }
            else
            {
                Console.WriteLine("Only '1' and '2' are accepted inputs");
            }

        }
    }
}
