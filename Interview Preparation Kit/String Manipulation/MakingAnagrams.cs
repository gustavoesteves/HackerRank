using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.String_Manipulation
{
    public static class MakingAnagrams
    {
        public static string Solution(string a, string b)
        {
            int[] letterCounts = new int[26];

            foreach (char c in a) { letterCounts[c - 'a']++; }
            foreach (char c in b) { letterCounts[c - 'a']--; }

            return letterCounts.Sum(x => Math.Abs(x)).ToString();
        }
    }
}
