using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.Arrays
{
    static class NewYearChaos
    {
        // 1 2 3 4 5 6 7 8
        // 1 2 3 5 4 6 7 8
        // 1 2 5 3 4 6 7 8
        // 1 2 5 3 4 7 6 8
        // 1 2 5 3 7 4 6 8
        // 1 2 5 3 7 4 8 6
        // 1 2 5 3 7 8 4 6
        // 1 2 5 3 7 8 6 4

        public static void Solution(int[] q)
        {
            var result = 0;
            bool toChaotic = false;
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] > i + 1 && q[i] - (i + 1) > 2)
                {
                    toChaotic = true;
                    break;
                }
                else
                {
                    result += q[i] - (i + 1);
                }
            }
            if (toChaotic) { Console.WriteLine("Too chaotic"); }
            else { Console.WriteLine(result); }
        }
    }
}
