using System;
namespace ProblemSolvingPratice
{
    internal class Program
    {
        /// <summary>
        /// Leetcode 162: Find Peak Element
        /// https://leetcode.com/problems/find-peak-element/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindPeakElement(int[] nums)
        {
            int min = 0;
            int max = nums.Length - 1;
            while (min < max)
            {
                int mid = (min + max) / 2;
                if (nums[mid] < nums[mid + 1])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }

            }
            return min;
        }
        static void Main(string[] args)
        {   
            int[] arr = {1, 2, 3, 1};
            int peak = FindPeakElement(arr);

            Console.WriteLine($"Peak Element of {nameof(arr)} is at index: {peak}");
        }
    }
}
