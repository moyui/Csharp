using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime start = now.AddDays(1 - now.Day);
            DateTime last = start.AddMonths(1).AddDays(-1);
            int i=0;
            while (start != last)
            {
                String xinqi = start.DayOfWeek.ToString();
                if (xinqi != "Saturday" && xinqi != "Sunday")
                {
                    i++;
                }
                start = start.AddDays(1);
            }
            Console.Write("本月工作日共有{0}天", i);
            Console.ReadLine();
        }
    }
}
