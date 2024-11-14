using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Chapter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();

            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
            Console.WriteLine($"{name}s age is {age}");
            byte number = 5;
            long bigNum;
            double wage = 56.77;
            number++;
            Console.WriteLine(number);





            Console.ReadLine();
        }
    }
}
