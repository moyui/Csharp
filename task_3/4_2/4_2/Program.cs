using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_2
{
    class Program
    {
        static int fib(int N) 
        {
            if (N == 1 || N == 0) return 1;
            else 
            {
                return fib(N - 1) + fib(N - 2);
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++) {
                Console.Write("{0} ", fib(i));
            }
            Console.ReadLine();
        }
    }
}
