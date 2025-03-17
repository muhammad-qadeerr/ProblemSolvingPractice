using System;
namespace ProblemSolvingPratice
{
    internal class Program
    {
        /// <summary>
        /// LeetCode - 1006 - Clumsy Factorial
        /// https://leetcode.com/problems/clumsy-factorial/description/
        /// clumsy(10) = 10 * 9 / 8 + 7 - 6 * 5 / 4 + 3 - 2 * 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Clumsy(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 6;

            int result = n * (n - 1) / (n - 2) + (n - 3);
            n -= 4;

            while (n >= 4)
            {
                result -= n * (n - 1) / (n - 2);
                result += (n - 3);
                n -= 4;
            }

            if (n == 3)
                result -= 3 * 2 / 1;
            else if (n == 2)
                result -= 2 * 1;
            else if (n == 1)
                result -= 1;

            return result;
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
            int n1 = 4;
            Console.WriteLine($"Clumsy Factorial of {n1} is {Clumsy(4)}");
            int n2 = 10;
            Console.WriteLine($"Clumsy Factorial of {n2} is {Clumsy(4)}");
            Console.WriteLine("------------------------------------------------------------------");
            int num = 3;
            int factorial = findFactorialRecursively(num);
            Console.WriteLine($"Factorial of the number {num} is: {factorial}");

        }
    }
}
