/*
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num = 1;

            while (true)
            {
                for (i=1; i<=20; ++i)
                {
                    if (num % i != 0)
                        break;
                }
                if (i == 21)
                    break;
                ++num;
            }

            Console.WriteLine("Answer: " + num);
        }
    }
}
