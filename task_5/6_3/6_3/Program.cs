using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11];//第一位留给最大数
            int point = 0;//记录下标
            Random rd = new Random();
            for (int i = 1; i < 11; i++)
            {
                arr[i] = rd.Next(10, 100);
                Console.Write("{0} ", arr[i]);
            }
            arr[0] = arr[1];
            for (int i = 1; i < 11; i++)
            {
                if (arr[i] > arr[0]) 
                {
                    arr[0] = arr[i];
                    point = i - 1;
                }
            }
            Console.WriteLine("\n最大值为{0},下标为{1}", arr[0], point);
            Console.ReadLine();
        }
    }
}
