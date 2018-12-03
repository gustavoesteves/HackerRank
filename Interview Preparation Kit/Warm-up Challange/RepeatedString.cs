using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.Warm_up_Challange
{
    public class RepeatedString
    {
        public static long Solution(string s, long n)
        {
            long count = 0;

            foreach (char c in s)
                if (c == 'a')
                    count++;

            long f = n / s.Length;
            long remain = n % s.Length;
            long r = 0;

            for (int i = 0; i < remain; i++)
                if (s[i] == 'a')
                    r++;

            return f * count + r;
        }
    }
}
