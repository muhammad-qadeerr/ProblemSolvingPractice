using System;
using System.Collections;

namespace ProblemSolvingPratice
{
    internal class Program
    {
        public static void removeLeadingAndTrailingSpace(string str1)
        {
            int start = 0;
            int end = str1.Length - 1;
            string result = string.Empty;
            while (start <= end && str1[start] == ' ') start++;
            while (end >= start && str1[end] == ' ') end--;

            //for (int i = start; i <= end; i++)
            //{
            //    result += str1[i];
            //}

            int index = 0;
            foreach (char c in str1)
            {
                if (index >= start && index <= end)
                {
                    result += c;
                }
                index++;
            }

            // Alternate Solutions
            //result = str1.Substring(start, end - start + 1);
            //string result = str1.Trim();
            Console.WriteLine($"After removing leading and traling spaces: {result}");
        }

        public static void reverseString(string str)
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

        public static void reverseStringWithoutReversingItsWords(string str)
        {
            int start = 0, end = str.Length - 1;
            string result = string.Empty;
            string word = string.Empty;

            for (int i = end; i >= start; i--)
            {
                if (str[i] != ' ')
                {
                    word = str[i] + word;
                }
                else
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        result += word + " ";
                        word = string.Empty;
                    }
                }
            }

            if (!string.IsNullOrEmpty(word))
            {
                result += word;
            }

            Console.WriteLine($"Reversed string without reversing its words: '{result.Trim()}'");
        }

        public static int[] sortArrayInSingleLoop(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    i = -1;
                }
            }
            return arr;
        }
        public static int findFactorialUsingLoop(int num)
        {
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int findFactorialRecursively(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            int factorial = num * findFactorialRecursively(num - 1);
            return factorial;
        }




        static void Main(string[] args)
        {
            // string str = " qadeer ";
            // string result = string.Empty;
            // foreach(char c in str){
            //     if(c != ' '){
            //         result += c;
            //     }
            // }

            string str = "  This is a book   ";
            string str1 = "Some String";
            string str2 = "This is a book";
            removeLeadingAndTrailingSpace(str);
            reverseString(str1);
            reverseStringWithoutReversingItsWords(str2);

            int[] arr = { 7, 8, 5, 2, 1 };
            int[] sortedArray = sortArrayInSingleLoop(arr);
            Console.WriteLine($"Reversed Array: {string.Join(", ", sortedArray)}");
            int num = 3;
            int factorial = findFactorialRecursively(num);
            Console.WriteLine($"Factorial of the number {num} is: {factorial}");
        }
    }
}
