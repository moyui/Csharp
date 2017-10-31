using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int nowYear = now.Year;
            DateTime firstDay = new DateTime(nowYear, 1, 1);
            DateTime lastDay = new DateTime(nowYear + 1, 1, 1).AddDays(-1);
            Console.WriteLine("本年度第一天是{0:m}，最后一天是{1:m}", firstDay, lastDay);
            Console.ReadLine();
        }
    }
}
