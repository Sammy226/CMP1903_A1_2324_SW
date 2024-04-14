using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public ThreeOrMore ThreeT = new ThreeOrMore();
        SevensOut SevensT = new SevensOut();


        public void TestThreeOrMore()
        {
            int ThreeTest = ThreeT.PlayThreeOrMore();
            if (ThreeTest == 20)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Press anything to close");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
            else if (ThreeTest > 20)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Press anything to close");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void TestThreeOrMorePVC()
        {
            int ThreeTest = ThreeT.PlayThreeOrMorePVC();
            if (ThreeTest == 20)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Press anything to close");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
            else if (ThreeTest > 20)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Press anything to close");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public bool TestSevensOut(int i, int j)
        {
            if (i + j == 7)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
