using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public static void removeLeadingAndTrailingSpace(string str1)
        {
            int start = 0;
            int end = str1.Length - 1;
            string result = string.Empty;
            while (start <= end && str1[start] == ' ') start++;
            while (end >= start && str1[end] == ' ') end--;


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

        public static int missingNoInSortedArray(int[] arr)
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


        public static int climbStairs(int n)
        {
            if (n <= 2) return n;
            int prev2 = 1, prev1 = 2;
            for (int i = 3; i <= n; i++)
            {
                int curr = prev1 + prev2;
                prev2 = prev1;
                prev1 = curr;
            }
            return prev1;
        }

        // LeetCode: 88 Merge Sorted Array

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // Pointer for nums1 (excluding the trailing zeros)
            int j = n - 1; // Pointer for nums2
            int k = m + n - 1; // Pointer for inserting in nums1 from the end

            // Merge nums1 and nums2 from the back
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            // If nums2 is not fully merged, copy remaining elements
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }

        //125. Valid Palindrome
        public static bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
            Stack<char> stack = new Stack<char>();

            string result = string.Empty;

            foreach (char c in s)
            {
                stack.Push(c);
            }

            foreach (char c in s)
            {
                if (stack.Pop() != c)
                {
                    return false;
                }
            }

            return true;

        }

        // Leetcode 168. Excel Sheet Column Title

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

        // Leetcode: 3. Longest Substring Without Repeating Characters
        // https://leetcode.com/problems/longest-substring-without-repeating-characters/description/

        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new HashSet<char>();
            int left = 0, maxLength = 0;
            for (int right = 0; right < s.Length; right++)
            {
                while (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }
                charSet.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }

        // Leetcode 141. Linked List Cycle
        // https://leetcode.com/problems/linked-list-cycle/description/
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }
            return false;
        }

        // Leetcode 162: Find Peak Element
        // https://leetcode.com/problems/find-peak-element/description/

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

        // Leetcode 167 - Two Sum II (Input Array is Sorted)
        // https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        public static int[] TwoSum(int[] numbers, int target)
        {
            int start = 0, end = numbers.Length - 1;

            while (start < end)
            {
                if (numbers[start] + numbers[end] == target)
                {
                    return new int[] { start + 1, end + 1 };
                }
                else if (numbers[start] + numbers[end] > target)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return new int[] { -1, -1 };

        }

        // Leetcode 1: Simple Two Sum
        public static int[] TwoSumSimple(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            return new int[] { -1, -1 }; // Return a default value if no solution exists
        }

        // LeetCode 283. Move Zeroes
        // https://leetcode.com/problems/move-zeroes/description/

        public static void MoveZeroes(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[count];
                    nums[count] = temp;

                    count++;
                }
            }
        }

        // Leetcode 169: Majority Element
        // https://leetcode.com/problems/majority-element/
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
            /*
            int[] arr = { 0, 1, 0, 3, 12 };
            MoveZeroes(arr);

            Console.Write("Array after moving zeros: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine("------------------------------------------------------------");

            string str = " qadeer ";
            string result = string.Empty;
            foreach (char c in str)
            {
                if (c != ' ')
                {
                    result += c;
                }
            }

            //string str = "  This is a book   ";
            string str1 = "Some String";
            removeLeadingAndTrailingSpace(str);

            int[] arr = { 7, 8, 5, 2, 1 };
            int[] sortedArray = sortArrayInSingleLoop(arr);
            Console.WriteLine($"Reversed Array: {string.Join(", ", sortedArray)}");
            int num = 3;
            int factorial = findFactorialRecursively(num);
            Console.WriteLine($"Factorial of the number {num} is: {factorial}");

            Console.WriteLine("---------------------------------------------------------");
            int[] arr1 = { 1, 2, 4, 5, 6 };
            int missingNum = missingNoInSortedArray(arr1);
            Console.WriteLine($"Missing num in array is: {missingNum}");

            Console.WriteLine("---------------------------------------------------------");

            int steps = climbStairs(4);
            Console.WriteLine($"No of Steps are: {steps}");

            Console.WriteLine("------------------------------------------------------------");

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            Merge(nums1, 3, nums2, 3);

            Console.WriteLine("------------------------------------------------------------");

            string strr = "A man, a plan, a canal: Panama";

            bool isValidPalindrom = IsPalindrome(strr);
            Console.WriteLine($"String: {strr} ----  is valid palindrom ? : {isValidPalindrom}");

            Console.WriteLine("------------------------------------------------------------");

            string coloumnTitle = ConvertToTitle(29);
            Console.WriteLine($"coloumnTitle: {coloumnTitle}");

            Console.WriteLine("------------------------------------------------------------");

            string inputStr = "abcabcbb";
            // Case2: 
            inputStr = "pwwkew";
            int lenOfLongestSubStr = LengthOfLongestSubstring(inputStr);
            Console.WriteLine($"Input Str: {inputStr}: Length of Longest Substring: {lenOfLongestSubStr}");

            Console.WriteLine("------------------------------------------------------------");

            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);

            // Creating a cycle
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            //node4.next = node2;

            // No Cycle

            node4.next = null;

            bool isLLCyclic = HasCycle(node1);

            Console.WriteLine($"Linklist head {nameof(node1)} has cycle: {isLLCyclic}");

            Console.WriteLine("------------------------------------------------------------");

            int[] arr = {1, 2, 3, 1};
            int peak = FindPeakElement(arr);

            Console.WriteLine($"Peak Element of {nameof(arr)} is at index: {peak}");

            //int[] arr = { 2, 7, 11, 15 };
            //int[] twoSumIndex = TwoSum(arr, 9);

            int[] arr = { 2, 3, 4 };
            int[] twoSumIndex = TwoSum(arr, 6);

            Console.WriteLine($"Array: {nameof(arr)} has target on indexes: [{twoSumIndex[0]}, {twoSumIndex[1]}]");

            int[] arr1 = { 2, 7, 11, 15 };
            int[] simpleTwoSumIndex = TwoSumSimple(arr1, 9);
            Console.WriteLine($"Array: {nameof(arr1)} has target on indexes: [{simpleTwoSumIndex[0]}, {simpleTwoSumIndex[1]}]");
            */








        }
    }
}
