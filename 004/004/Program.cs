/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong store = 0;
            ulong largestPalindrome = 0;
            for (ulong lhs=999; lhs>=100; --lhs)
            {
                for (ulong rhs=999; rhs>=100; --rhs)
                {
                    store = lhs * rhs;
                    if (isPalindrome(store) && store > largestPalindrome)
                    {
                        largestPalindrome = store;
                    }
                }
            }

            Console.WriteLine("Palindrome: " + largestPalindrome);
        }

        static bool isPalindrome(ulong val)
        {
            string valstring = val.ToString();
            string reverseString = new string(valstring.ToCharArray().Reverse().ToArray());
            
            return valstring == reverseString;
        }
    }
}
