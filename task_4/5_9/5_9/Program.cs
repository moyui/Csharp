using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime start = now.AddDays(1 - Convert.ToInt32(now.DayOfWeek));
            DateTime last = start.AddDays(6);
            Console.Write("本周一为{0:D},本周日为{1:D}", start, last);
            Console.ReadLine();
        }
    }
}
