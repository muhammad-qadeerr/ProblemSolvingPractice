using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingPratice
{
    internal class Program
    {
        /// <summary>
        /// Leetcode 169: Majority Element
        /// https://leetcode.com/problems/majority-element/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement(int[] nums)
        {
            int compareOccurance = nums.Length / 2;
            // creating a HashMap using Dictionary in C# to store the count
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            return countMap.Where(e => e.Value > compareOccurance).Select(ele => ele.Key).FirstOrDefault();
        }
        static void Main(string[] args)
        {

            int[] arr = { 2, 2, 1, 1, 1, 2, 2 };
            Console.Write($"Majority Element is: {MajorityElement(arr)}");
        }
    }
}
