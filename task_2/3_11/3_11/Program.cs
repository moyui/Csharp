using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_11
{
    class Program
    {
        static int digui(int n) {
            if (n == 1) return 1;
            else {
                return n*digui(n - 1);
            }
        }

        static int[] Pnum(int N) {
            int[] arr = new int[N];
            int j = 2, k = 0;
            for (int i = 0; i < N; i++) {
                arr[i] = 1;
            }
            arr[0] = arr[1] = 0;
            while (j < N) {
                while (arr[j++] == 1 ) {
                    k = j - 1;
                    break;
                }
                for (int i = 2; k * i < N; i++) {
                    arr[k * i] = 0;
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int sum = 0 , count = 0;
            for (int i = 100; i <= 500; i++) {
                if (i % 2 != 0) {
                    sum += i;
                }
            }
            Console.WriteLine("100~500内的奇数和为：{0}", sum);
            sum = 0;
            Console.WriteLine("100~300内的不能被3整除的数为：");
            for (int i = 100; i <= 200; i++) {
                if (i % 3 != 0) {
                    Console.Write("{0} ", i);
                }
            }
            sum = 0;
            for (int i = 1; i <= 1000; i++) {
                if (i % 5 == 0 && i % 7 == 0) {
                    count++;
                }
            }
            Console.WriteLine("\n1~1000内既能被5整除又能被7整除的数个数为：{0}", count);
            Console.WriteLine("从300开始找出100个既能被3整除又能被7整除的数");
            count = 0;
            int j = 300;
            while(count < 100) {
                if (j % 3 == 0 && j % 5 == 0) {
                    Console.Write("{0} ", j);
                    count++;
                }
                j++;
            }
            Console.WriteLine("\n请输入正整数n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                int part = digui(i);
                sum += part;
            }
            Console.WriteLine("S = {0}", sum);
            sum = 0;
            count = 0;
            int[] pNum = Pnum(1000);
            Console.WriteLine("不大于1000的十个最大素数:");
            for (int i = 999; i >= 0; i--) {
                if (pNum[i] == 1) {
                    Console.Write("{0} ", i);
                    count++;
                }
                if (count >= 9) {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
