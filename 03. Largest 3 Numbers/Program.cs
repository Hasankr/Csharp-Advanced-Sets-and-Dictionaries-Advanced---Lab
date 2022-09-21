using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers = numbers.OrderByDescending(x => x).ToList();
            int count = numbers.Count;
            if (count > 3)
            {
                count = 3;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
