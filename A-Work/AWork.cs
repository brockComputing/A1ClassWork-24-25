using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Work
{
    internal class AWork
    {
        static void Main(string[] args)
        {
            int choice, denNumber, bit, colheader;
            string binStr, hexStr;
            choice = 0;
            do
            {
                binStr = "";
                denNumber = 0;
                Console.WriteLine("1. Denary to Binary");
                Console.WriteLine("2. Binary to Denary");
                Console.WriteLine("9. To exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {

                }
                else if (choice == 2)
                {
                    binStr = "1100";
                    bit = Convert.ToInt32(binStr[1].ToString());
                    Console.WriteLine($"bit is {bit}");
                }
                else if (choice == 3)
                {

                }
            } while (choice != 9);



        }
    }
}
