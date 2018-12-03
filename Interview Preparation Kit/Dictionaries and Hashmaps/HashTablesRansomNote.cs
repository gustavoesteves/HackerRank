using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.Dictionaries_and_Hashmaps
{
    public static class HashTablesRansomNote
    {
        public static string Solution(string[] m, string[] r)
        {
            List<string> _m = m.ToList();
            List<string> _r = r.ToList();
            _m.Sort();
            _r.Sort();

            string result = "Yes";
            foreach (var item in _r)
            {
                if (!_m.Remove(item))
                {
                    result = "No";
                    break;
                }
            }
            return result;
        }
    }
}
