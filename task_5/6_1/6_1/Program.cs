using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String inArr = Console.ReadLine();
            Char[] arr = inArr.ToCharArray();
            int i = 0;
            int j = arr.Length - 1;
            int warn = 0;
            while (i <= j)
            {
                if (arr[i] != arr[j])
                {
                    Console.WriteLine("不是回文数！");
                    warn = 1;
                    break;
                }
                i++;
                j--;
            }
            if (warn == 0)
            {
                Console.WriteLine("是回文数！");
            }
            Console.ReadLine();
        }
    }
}
