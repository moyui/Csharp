using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_7
{
    class quickSort
    {
        private static void each(int[] arr, int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
        private static int partition(int[] arr, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            int v = arr[lo];
            while (true)
            {
                while (arr[++i] < v) if (i == hi) break;
                while (v < arr[--j]) if (j == lo) break;
                if (i >= j) break;
                each(arr, i, j);
            }
            each(arr, lo, j);
            return j;
        }
        public static void sort(int[] arr)
        {
            sort(arr, 0, arr.Length - 1);
        }
        public static void sort(int[] arr, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = partition(arr, lo, hi);
            sort(arr, lo, j - 1);
            sort(arr, j + 1, hi);
        }

    }
}
