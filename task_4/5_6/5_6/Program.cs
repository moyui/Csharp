using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime startTime = now.AddMonths(- (now.Month - 1) % 3).AddDays(1 - now.Day);
            DateTime lastTime = startTime.AddMonths(3).AddDays(-1);
            Console.WriteLine("本季度的日期范围是{0:D}~{1:D}", startTime, lastTime);
            Console.ReadLine();
        }
    }
}
