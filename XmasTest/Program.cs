using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasProgrammingTest_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower = 10, upper = 20;
            bool isPrime = true; ;
            for (int i = lower; i <= upper; i++)
            {
                isPrime = true;
                for (int num = 2; num < i; num++)
                {
                    if (i % num == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
