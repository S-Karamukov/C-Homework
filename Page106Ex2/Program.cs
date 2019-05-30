using System;
using System.Collections.Generic;

namespace Page106Ex2
{
    class Im_a_CodeMoron
    {
        static void Printpairs(int[] arr, int sum)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < arr.Length; ++i)
            {
                int temp = sum - arr[i];
                if (temp >= 0 && s.Contains(temp))
                {
                    Console.Write("Pair with given sum " + sum + " is (" + arr[i] + ", " + temp + ")");
                }
                s.Add(arr[i]);
            }
        }
        static void Main()
        {
            int[] A = new int[] { 1, 4, 45, 6, 10, 8 };
            int n = 16;
            Printpairs(A, n);
        }
    }
}