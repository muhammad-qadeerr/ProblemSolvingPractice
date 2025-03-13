using System;
using System.Linq;

namespace ProblemSolvingPratice
{
    internal class Program
    {
        //Leetcode 26: remove Duplicates
        // https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

        public static int RemoveDuplicates(int[] nums)
        {
            if (!nums.Any()) return 0;

            int j = 1;  // Index for placing the next unique element.

            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j] = nums[i];
                    ++j;
                }
            }
            return j;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2 };
            Console.WriteLine($"Unique Elements after removing duplicates from {nameof(arr)} are: {RemoveDuplicates(arr)}");
        }
    }
}
