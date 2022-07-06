using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Algorithm
{
    public static class SortArray
    {
        public static string Sort(int[] array)
        {
            string sorted = "";
            string zeros = "";
            string ones = "";
            string twos = "";
            for (int i = 0; i <= array.Length -1; i++)
            {
                if (array[i] == 0)
                {
                    zeros += array[i].ToString();
                }
                if (array[i] == 1)
                {
                    ones += array[i].ToString();
                }
                if (array[i] == 2)
                {
                    twos += array[i].ToString();
                }
            }
            sorted = zeros+ ones + twos;
            return sorted;
        }
    }
}
