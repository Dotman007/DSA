using AlgorithmPractice.Algorithm;
using AlgorithmPractice.Datastructure;
using AlgorithmPractice.TechInterview;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice
{
    internal class Program
    {
        public static string insert(int[] array)
        {
            string result = string.Empty;
            int counter = 0;
            int sum = 1;
            int keeper = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i == counter)
                {
                    keeper  =  array[i];
                    array[i] = 1;
                    Console.WriteLine(i);
                    Array.ForEach(array, j => sum *= j);
                    array[i] = keeper;
                }
                counter += 1;
                result += sum;
                sum = 1;

            }
            return result;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();
            //Array.Sort(nums);
            int sumUp = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                var checkMatch = target - nums[i];
                var checkPostion = Array.IndexOf(nums, checkMatch);
                if (checkPostion > -1)
                {
                    result.Add(i);
                    sumUp += nums[i];
                    if (sumUp > target)
                    {
                        
                        if(sumUp < 0)
                        {
                            sumUp = -sumUp + target;
                        }
                        else
                        {
                            sumUp = sumUp - target;
                        }
                        var getIndexOfExcess = Array.IndexOf(nums,sumUp);
                        if (getIndexOfExcess > -1 && result.Count > getIndexOfExcess)
                        {
                            result.RemoveAt(getIndexOfExcess);
                        }
                    }
                }

            }
            return result.ToArray();
        }

        static string Rearrange(int value, int[] array, int index)
        {
            int counter  = 1;
            int tracker = 0;
            for (int i = array.Length - index; i < array.Length -counter; i++)
            {
                tracker = array[index];
                array[index] = value;
                array[index + counter] = tracker;
                counter++;


            }
            return string.Join("",array);
        }
        static void Main(string[] args)
        {

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(1);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
