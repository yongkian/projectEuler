using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            int prev = 1;
            int curr = 2;
            int sum = curr;
            int store = 0;
            while ((store = prev+curr) <= 4000000)
            {
                prev = curr;
                curr = store;

                if (curr % 2 == 0)
                    sum += curr;
            }
            Console.WriteLine("SUM: " + sum);
        }
    }
}
