using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingPratice
{
    internal class Program
    {
        /// <summary>
        /// Leetcode - 268 (Missing Number in UnSorted Array)
        /// https://leetcode.com/problems/missing-number/
        /// Solution Done using Sum Formula
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MissingNumberInUnSortedArray(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = nums.Sum();
            return expectedSum - actualSum;
        }

        /// <summary>
        /// Missing Number in Sorted Array (Similar to Leetcode 268) (Avaiable in Leetcode Premium)
        /// https://leetcode.com/problems/missing-element-in-sorted-array/description/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int MissingNoInSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i] + 1;
                }
            }

            throw new Exception("No missing number in the array.");
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };
            int missingNumber = MissingNumberInUnSortedArray(nums);
            Console.WriteLine($"Missing num in Sorted Array {nameof(nums)} is: {missingNumber}");

            Console.WriteLine("------------------------------------------------------------------------");

            int[] arr1 = { 1, 2, 4, 5, 6 };
            int missingNum = MissingNoInSortedArray(arr1);
            Console.WriteLine($"Missing num in Unsorted Array {nameof(arr1)} is: {missingNum}");

        }
    }
}
