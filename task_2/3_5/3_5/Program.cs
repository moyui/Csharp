using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_5
{
    class BinarySearch
    {
        public static int rank(int key, int[] a)
        {
            return rank(key, a, 0, a.Length - 1);
        }
        public static int rank(int key, int[] a, int lo, int hi)
        {
            if (lo > hi) return -1;
            int mid = lo + (hi - lo) / 2;
            if (key < a[mid]) return rank(key, a, lo, mid - 1);
            else if (key > a[mid]) return rank(key, a, mid + 1, hi);
            else return mid;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[900];
            for (int i = 100; i <= 999; i++)
            {
                arr[i - 100] = i;
            }
            int N = arr.Length;
            for (int j = 0; j < N; j++)
            {
                int x = BinarySearch.rank(1333 - arr[j], arr);
                if ((x > j))
                {
                    if (arr[x] / 100 == arr[j] % 10 && arr[x] / 10 % 10 == arr[j] / 10 % 10 && arr[x] % 10 == arr[j] / 100)
                    {
                        int a, b, c;
                        a = arr[j] / 100;
                        b = arr[j] / 10 % 10;
                        c = arr[j] % 10;
                        Console.WriteLine("a = {0}, b = {1}, c = {2}\n", a, b, c);
                        Console.WriteLine("a = {0}, b = {1}, c = {2}\n", c, b, a);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
