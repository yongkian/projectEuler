/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            // find all multiples of 3 below 1000
            List<int> mul = new List<int>();
            for (int i=3; i<1000; ++i)
            {
                if (i%3 == 0)
                    mul.Add(i);
            }

            // find all multiples of 5 that isn't a multiple of 3
            for (int i = 5; i < 1000; ++i)
            {
                if (i%5 == 0 && i%3 != 0)
                    mul.Add(i);
            }

            int sum = 0;
            foreach (int elem in mul)
            {
                sum += elem;
            }

            Console.WriteLine("SUM: " + sum);
        }
    }
}
