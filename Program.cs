using System;
using System.Collections;
namespace ProblemSolvingPratice
{
    internal class Program
    {
        /// <summary>
        /// LeetCode-344 - reverse string using O(1) Memory
        /// https://leetcode.com/problems/reverse-string/description/
        /// </summary>
        /// <param name="str"></param>
        public static void reverseStringWithoutExtraMemory(Span<char> str)
        {
            int left = 0, right = str.Length - 1;

            while (left < right)
            {
                (str[left], str[right]) = (str[right], str[left]);
                left++;
                right--;
            }
        }

        /// <summary>
        /// LeetCode-344 - reverse string using stack (more memory)
        /// https://leetcode.com/problems/reverse-string/description/
        /// </summary>
        /// <param name="str"></param>
        public static void reverseStringWithExtraMemory(string str)
        {
            Stack stk = new Stack();
            foreach (char c in str)
            {
                stk.Push(c);
            }
            string reverseString = string.Empty;
            foreach (char c in str)
            {
                reverseString += stk.Pop();
            }
            Console.WriteLine($"Revered String: {reverseString}");
        }

        static void Main(string[] args)
        {
            char[] str = new char[] { 'h', 'e', 'l', 'l', 'o' };
            reverseStringWithoutExtraMemory(str);
            Console.WriteLine(new string(str));

            string str2 = "Some String";
            reverseStringWithExtraMemory(str2);



        }
    }
}
