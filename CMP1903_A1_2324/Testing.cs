using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
            Debug.Assert(ThreeTest == 20 | ThreeTest > 20);
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Press anything to close");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
        }

        public void TestThreeOrMorePVC()
        {
            int ThreeTest = ThreeT.PlayThreeOrMorePVC();
            Debug.Assert(ThreeTest == 20 | ThreeTest > 20);
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Press anything to close");
                Console.WriteLine(" ");
                Console.ReadKey();
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
