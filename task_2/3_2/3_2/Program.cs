using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()),
                i, j, k;
            for (i = num; i > 0; i = i - 2)
            {
                for (k = (num - i) / 2; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
