using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Interview_Preparation_Kit.Arrays
{
    public static class LeftRotation
    {
        public static string Solution(int rot, int[] arr)
        {
            string left = string.Join(" ", arr.Take(rot).ToArray());
            string right = string.Join(" ", arr.Skip(rot).ToArray());

            return right + ' ' + left;
        }
    }
}
