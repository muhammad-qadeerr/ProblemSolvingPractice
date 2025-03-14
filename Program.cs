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
        /// Leetcode 151 - Reverse Words in string
        /// https://leetcode.com/problems/reverse-words-in-a-string/
        /// </summary>
        /// <param name="str"></param>
        public static void reverseWordsInString(string str)
        {
            // Removing leading and trailing spaces in input string
            str = str.Trim();
            int start = 0, end = str.Length - 1;
            string result = string.Empty;
            string word = string.Empty;

            for (int i = end; i >= start; i--)
            {
                if (str[i] != ' ')
                {
                    word = str[i] + word;  // Build word iterating from last
                }
                else
                {
                    // add the words to result after building with a space
                    if (!string.IsNullOrEmpty(word))
                    {
                        result += word + " ";
                        word = string.Empty;
                    }
                }
            }
            // add last word to the result
            if (!string.IsNullOrEmpty(word))
            {
                result += word;
            }

            Console.WriteLine($"Reversed string without reversing its words: '{result.Trim()}'");
        }
        static void Main(string[] args)
        {
            //string str1 = "This is a book";
            //reverseWordsInString(str1);

            string str1 = " Hello    World ";
            reverseWordsInString(str1);
        }
    }
}
