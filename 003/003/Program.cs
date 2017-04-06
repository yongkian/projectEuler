/*
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong val = 600851475143;
            ulong factor = 2;
            ulong largestPrimeFactor = 0;
            while (factor != val)
            {
                if (val % factor == 0 && isPrime(factor))
                {
                    Console.WriteLine("Prime factor: " + factor);
                    largestPrimeFactor = factor;
                }
                factor++;
            }

            if (largestPrimeFactor > 1)
            {
                Console.WriteLine("Largest Prime Factor: " + largestPrimeFactor);
            }
            else
            {
                Console.WriteLine("No Prime Factor");
            }
        }

        static bool isPrime(ulong val)
        {
            ulong factor = 2;
            while (factor!=val)
            {
                if (val % factor == 0)
                    return false;
                factor++;
            }
            return true;
        }
    }
}
