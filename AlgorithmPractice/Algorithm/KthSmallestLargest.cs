
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Algorithm
{
    public static class KthSmallestLargest
    {
        public static int FindSmallestLargest(List<int> arr, int l, int r, int k)
        {
            int res = 0;
            arr.Sort();
            for (int i = 0; i <= l-1; i++)
            {
                if (arr[i] == arr[k-1])
                {
                    res = arr[i];
                }
            }
            return res;
        }
    }

    public class SmallestLargest
    {
        public int KthSmallest { get; set; }
        public int KthLargest { get; set; }
    }
}
