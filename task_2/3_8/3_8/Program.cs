using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int[] arr = new int[7];
            double sum = 0;
            Console.WriteLine("请输入分数：");
            input = Console.ReadLine();
            for (int i = 0; i < 7; i++)
            {
                arr[i] = int.Parse(input.Split(' ')[i]);
            }
            Array.Sort(arr);
            for (int j = 1; j < 6; j++)
            {
                sum += arr[j];
            }
            Console.WriteLine("运动员的得分是{0}", sum / 5);
            Console.ReadLine();
        }
    }
}
