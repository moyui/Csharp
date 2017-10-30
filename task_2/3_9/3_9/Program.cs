using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int a = i / 100;
                int b = i / 10 % 10;
                int c = i % 10;
                if ((Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3)) == i)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.ReadLine();
        }
    }
}
