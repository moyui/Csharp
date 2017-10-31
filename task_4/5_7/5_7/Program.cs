using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int nowYear = now.Year;
            int nowMonth = now.Month;
            DateTime firstDay = new DateTime(nowYear, nowMonth, 1);
            DateTime lastDay = new DateTime(nowYear, nowMonth, 1).AddMonths(1).AddDays(-1);
            Console.WriteLine("本月第一天是{0:m}，最后一天是{1:m}", firstDay, lastDay);
            Console.ReadLine();
        }
    }
}
