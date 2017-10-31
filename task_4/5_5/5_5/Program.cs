using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime next = now.AddYears(1);
            String xingqi = next.DayOfWeek.ToString();
            Console.WriteLine("明年的今天是{0}", xingqi);
            Console.ReadLine();
        }
    }
}
