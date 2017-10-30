using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_6
{
    class Program
    {
        static int chitao(int x)
        {
            if (x == 1) return 1;
            else
            {
                x--;
                return 2 * (chitao(x) + 1);
            }
        }

        static void Main(string[] args)
        {
            int sum = chitao(10);
            Console.WriteLine("猴子第一天总共摘了{0}个", sum);
            Console.ReadLine();
        }
    }
}
