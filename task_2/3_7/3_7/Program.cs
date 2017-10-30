using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int man = 0; man <= 30; man++)
            {
                for (int woman = 0; woman <= 30; woman++)
                {
                    for (int child = 0; child <= 30; child++)
                    {
                        if ((man + woman + child) == 30 && (3 * man + 2 * woman + 1 * child) == 50)
                        {
                            Console.WriteLine("男人有{0}人，女人有{1}人，孩子有{2}人\n", man, woman, child);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
