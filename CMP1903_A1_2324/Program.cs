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

            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(3);
            ints.Add(3);
            ints.Add(6);
            List<int> list2 = ints.Distinct().ToList();
            list2.ForEach(Console.WriteLine);

            Start.SelectGame();
        }
    }
}