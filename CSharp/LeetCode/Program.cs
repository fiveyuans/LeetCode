using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new _004.Median_of_Two_Sorted_Arrays();
            //var re = test.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });

            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 9, 1, 2, 3, 4, 5, 6, 7, 9, 12 };
            //int r = a[0];
            //for (int i = 1; i < a.Length; i++)
            //{
            //    r = r ^ a[i];
            //}
            //Console.WriteLine(r.ToString());
            testobj t = new testobj();
            t.s = "new";
            add(t);

            Console.WriteLine(t.s);

            Console.ReadLine();
        }
        public static void add(testobj t)
        {
            t.s = t.s + "add";
        }
        public class testobj
        {
            public string s;
        }

    }
}
