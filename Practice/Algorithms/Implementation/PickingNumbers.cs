using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Practice.Algorithms.Implementation
{
    class Numbers
    {
        public int Item { get; set; }
        public int Sum { get; set; }
        public Numbers(int item, List<int> sum)
        {
            this.Item = item;
            this.Sum = sum.FindAll(_ => _.Equals(item)).Count();
        }
    }

    class PickingNumbers
    {
        public static void Solution(List<int> a)
        {
            List<Numbers> _numbers = new List<Numbers>();
            a.Distinct().ToList().ForEach(delegate (int item) { _numbers.Add(new Numbers(item, a)); });

            if(_numbers.Count() == 1) { Console.WriteLine(_numbers[0].Sum); }

            List<int> _result = new List<int>();
            _numbers.ForEach(delegate (Numbers item)
            {
                if (_numbers.Exists(_ => _.Item.Equals(item.Item + 1)))
                {
                    _result.Add(item.Sum + _numbers.Find(_ => _.Item.Equals(item.Item + 1)).Sum);
                }
            });

            if (_numbers.Max(_ => _.Sum) > _result.Max()) { Console.WriteLine(_numbers.Max(_ => _.Sum)); }

            Console.WriteLine(_result.Max());
        }
    }
}