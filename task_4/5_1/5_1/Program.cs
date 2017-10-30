using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_1
{
    class Program
    {
        static Boolean Judge(int value, int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int value;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Random rnd = new Random();
                    value = rnd.Next(50, 99);
                } while (Judge(value, arr));
                arr[i] = value;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
