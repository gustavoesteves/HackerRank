using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.String_Manipulation
{
    public static class AlternatingCharacters
    {
        public static string Solution(string s)
        {
            string _s = "";
            int sum = 0;
            List<string> _ls = new List<string>(s.Select(x => x.ToString()).ToList());
            for (int i = 0; i < _ls.Count; i++)
            {
                if (_ls[i] == _s) sum++;
                else _s = _ls[i];
            }
            return sum.ToString();
        }
    }
}
