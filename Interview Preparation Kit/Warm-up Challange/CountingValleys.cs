using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.Warm_up_Challange
{
    public class CountingValleys
    {
        public static int Solution(int n, string s)
        {
            int _result = 0;
            char[] _steps = s.ToCharArray();
            int _altitude = 0;
            foreach (var item in _steps)
            {
                if (item == 'U') _altitude++;
                else _altitude--;
                if (_altitude == 0 && item == 'U') _result++;
            }
            return _result;
        }
    }
}
