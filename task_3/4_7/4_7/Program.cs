using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_7
{
    class Max 
    {
        public long a;
        public long b;
        public long compare() 
        {
            long temp;
            if (a >= b) temp = a;
            else temp = b;
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Max max_1 = new Max();
            max_1.a = long.Parse(Console.ReadLine());
            max_1.b = long.Parse(Console.ReadLine());
            Console.WriteLine("较大者为{0}", max_1.compare());
            Console.ReadLine();
        }
    }
}
