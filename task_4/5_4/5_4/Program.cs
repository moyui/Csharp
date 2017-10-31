using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Today;
            DateTime past = new DateTime(2009, 2, 18);
            TimeSpan ts = now.Subtract(past);
            int zhoushu = ts.Days / 7;
            Console.WriteLine("第{0}周", zhoushu);
            Console.ReadLine();
        }
    }
}
