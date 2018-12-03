using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HackerRank;

namespace HackerRank.Interview_Preparation_Kit.Warm_up_Challange
{
    public class SockMerchant
    {
        public static int Solution(int[] i)
        {
            return i.Distinct().Sum(x => i.Count(y => y == x) / 2);
        }
    }
}
