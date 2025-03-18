using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProblemSolvingPratice
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    internal class Program
    {
        /// <summary>
        /// Leetcode 168: Excel Sheet Column Title
        /// https://leetcode.com/problems/excel-sheet-column-title/
        /// </summary>
        /// <param name="columnNumber"></param>
        /// <returns></returns>

        public static string ConvertToTitle(int columnNumber)
        {

            int remainder = 0;
            string result = string.Empty;
            string finalResult = string.Empty;
            while (columnNumber > 0)
            {
                //Edge-case when value is 26 itself
                columnNumber--;
                remainder = columnNumber % 26;
                char c = (char)(remainder + 'A');
                result += c;
                columnNumber = columnNumber / 26;
            }
            Stack<char> stk = new Stack<char>();

            foreach (char c in result)
            {
                stk.Push(c);
            }
            foreach (char c in result)
            {
                finalResult += stk.Pop();
            }
            return finalResult;
        }

        static void Main(string[] args)
        {
            string coloumnTitle = ConvertToTitle(29);
            Console.WriteLine($"coloumnTitle: {coloumnTitle}");
        }
    }
}
