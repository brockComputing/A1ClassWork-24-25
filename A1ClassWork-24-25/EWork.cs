using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1ClassWork_24_25
{
    internal class EWork
    {
        static void Main(string[] args)
        {
            string binStr = "1011111111111111";
            int length = binStr.Length;
            Console.WriteLine($"the len is {length}");
            int bit = Convert.ToInt32(binStr[1].ToString());
            Console.WriteLine(bit);
            Console.ReadLine();
        }
    }
}
