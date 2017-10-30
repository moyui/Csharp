using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_10
{
    class Program
    {    
        static void Main(string[] args)
        {
            int sum;
            for (int i = 2; i < 1000; i++) {
                sum = 0;
                for (int j = 1; j < i; j++) {
                    if (i % j == 0) {                     
                        sum += j;
                    }
                }
                if (sum == i) {
                    Console.WriteLine("{0}\n", i);
                }
            }
            Console.ReadLine();
        }
    }
}
