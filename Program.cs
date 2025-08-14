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

        // 125. Valid Palindrome
        // https://leetcode.com/problems/valid-palindrome/description/
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
        // https://leetcode.com/problems/two-sum/description/
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

        // Leetcode 344. Reverse String
        // https://leetcode.com/problems/reverse-string/
        public static string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            int left = 0, right = str.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = str[right];
                chars[right] = temp;

                left++; right--;
            }
            return new string(chars);
        }
        
        static void Main(string[] args)
        {
            /*
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
            //int[] arr = { 2, 7, 11, 15 };
            //int[] twoSumIndex = TwoSum(arr, 9);

            int[] arr = { 2, 3, 4 };
            int[] twoSumIndex = TwoSum(arr, 6);

            Console.WriteLine($"Array: {nameof(arr)} has target on indexes: [{twoSumIndex[0]}, {twoSumIndex[1]}]");

            int[] arr1 = { 2, 7, 11, 15 };
            int[] simpleTwoSumIndex = TwoSumSimple(arr1, 9);
            Console.WriteLine($"Array: {nameof(arr1)} has target on indexes: [{simpleTwoSumIndex[0]}, {simpleTwoSumIndex[1]}]");
            */

            string test = "Hello";
            Console.WriteLine(ReverseString(test);
        }
    }
}
