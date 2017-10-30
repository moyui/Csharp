using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, x;
            int count = 1, y = 1;
            do
            {
                x = 1.0 / y;
                sum += x;
                y *= count;
                count++;
            } while (Math.Pow(10, -6) < x);
            Console.WriteLine("{0}\n最后一项是:{1}", sum, x);
            Console.ReadLine();
        }
    }
}
