using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.Warm_up_Challange
{
    public class JumpingontheClouds
    {
        public static int Solution(int[] c)
        {
            int result = 0;
            int step = 0;
            bool final = false;
            for (int i = 0; i < c.Length; i++)
            {
                if (step == 0 && c.Length - 1 != i)
                {
                    try
                    {
                        final = (c[i + 2] == 0);
                    }
                    catch (Exception)
                    {
                        final = false;
                    }
                    if (final)
                    {
                        result++;
                        step = 1;
                    }
                    else
                    {
                        result++;
                        step = 0;
                    }
                }
                else { step--; }
            }
            return result;
        }
    }
}
