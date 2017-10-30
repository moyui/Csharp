using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, x = 1, last = 1;
            int count = 1;
            while (Math.Pow(10, -6) < last)
            {
                x = (1.0 / (4 * count - 3)) - (1.0 / (4 * count - 1));
                last = (1.0 / (4 * count - 1));
                sum = sum + x;
                count++;
            }
            Console.WriteLine("{0}\n最后一位大小是:{1:e}", sum, last);
            Console.ReadLine();
        }
    }
}
