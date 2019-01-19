using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Practice.Algorithms.Implementation
{
    class UtopianTree
    {
        public static void Solution(int n)
        {
            int _result = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0) { _result++; }
                else { _result = _result * 2; }
            }
            Console.WriteLine(_result);
        }
    }
}
