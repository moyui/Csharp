using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculateCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double r;
            Console.WriteLine("请输入圆的半径:");
            s = Console.ReadLine();
            r = double.Parse(s);
            double area = Math.PI * r * r;
            Console.WriteLine("圆的面积是{0}", area);
            Console.ReadLine();
        }
    }
}
