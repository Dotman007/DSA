using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Algorithm
{
    public static class Frequency
    {

        public static int FindFrequency(int[] array, int x)
        {
            int counter = 0;
            for (int i = 0; i <= array.Length -1; i++)
            {
                if (array[i] == x)
                {
                    counter = counter + 1;
                }
            }
            return counter;
        }
    }
}
