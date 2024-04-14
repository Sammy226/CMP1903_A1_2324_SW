using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Statistics
    {
        int Players = 0;
        public int PlayerCount(int i)
        {
            Players = Players + i;
            return Players;
        }
    }

    internal class PlayerScores : Statistics
    {
        int SPlayer1 = 0;
        int SPlayer2 = 0;
        int TPlayer1 = 0;
        int TPlayer2 = 0;
        public int SevensOutScore1(int P1)
        {
            SPlayer1 = SPlayer1 + P1;
            return SPlayer1;
        }
        public int SevenOutScore2(int P2)
        {
            SPlayer2 = SPlayer2 + P2;
            return SPlayer2;
        }


        public int ThreeOrMoreScore1(int P1)
        {
            TPlayer1 = TPlayer1 + P1;
            return TPlayer1;
        }
        public int ThreeOrMoreScore2(int P2)
        {
            TPlayer2 = TPlayer2 + P2;
            return TPlayer2;
        }
    }
}
