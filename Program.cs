using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingPratice
{
    internal class Program
    {
        /// <summary>
        /// LeetCode 283. Move Zeroes
        /// https://leetcode.com/problems/move-zeroes/description/        
        /// <param name="nums"></param>
        /// </summary>

        public static void MoveZeroes(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // If number isn;t zero, keep it moving to right.
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[count];
                    nums[count] = temp;

                    count++;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            MoveZeroes(arr);

            Console.Write("Array after moving zeros: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
