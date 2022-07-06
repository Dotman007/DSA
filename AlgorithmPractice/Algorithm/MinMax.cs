using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Algorithm
{
    public class MinMaxModel
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
    }
    public static class MinMax
    {
        public static MinMaxModel GetMinMax(int[] array)
        {
            string response  = string.Empty;
            int temp;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = (i+1); j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return new MinMaxModel
            {
                Minimum =  array[array.Length - array.Length],
                Maximum =  array[array.Length-1]
            };
        }
    }
}
