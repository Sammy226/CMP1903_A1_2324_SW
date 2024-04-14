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
            Game Start = new Game();
            SevensOut SevensRules = new SevensOut();
            ThreeOrMore ThreeRules = new ThreeOrMore();

            SevensRules.SevensOutRules();
            ThreeRules.ThreeOrMoreRules();
            Start.SelectGame();
        }
    }
}