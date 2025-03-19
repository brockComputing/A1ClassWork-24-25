using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isOK = true;
            do
            {
                isOK = true;
                try
                {
                    Console.WriteLine("enter a number");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("enter numbers only");
                    isOK = false;
                }
            } while (isOK == false);

            Console.ReadLine();
        }
    }
}
