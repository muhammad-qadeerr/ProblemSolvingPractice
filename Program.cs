using System;
namespace ProblemSolvingPratice;
internal class Program
{ 
    static void Main(string[] args)
    {
        var mergeArray = new Leetcode.Problem088.MergeSortedArrays();
        Console.WriteLine($"============================ {mergeArray.GetProblemTitle()} ============================");
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        mergeArray.Merge(nums1, 3, nums2, 3);
        Console.WriteLine("Merged Array: " + string.Join(", ", nums1));

        var groupAnagrams = new Leetcode.Problem049.GroupAnagrams();
        Console.WriteLine($"\n============================ {groupAnagrams.GetProblemTitle()} ============================");
        var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var groupedAnagrams = groupAnagrams.GroupAnagramStrings(strs);
        Console.WriteLine("Grouped Anagrams:");
        foreach (var group in groupedAnagrams)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }

        var validateAnagram = new Leetcode.Problem242.ValidateAnagram();
        Console.WriteLine($"\n============================ {validateAnagram.GetProblemTitle()} ============================");
        string s = "rat";
        string t = "car";
        Console.WriteLine($"Is \"{s}\" an anagram of \"{t}\": {(validateAnagram.IsAnagram(s, t) ? "true" : "false")}");

        var checkArrayDuplicates = new Leetcode.Problem217.CheckArrayDuplicates();
        Console.WriteLine($"\n============================ {checkArrayDuplicates.GetProblemTitle()} ============================");
        int[] nums = { 1, 2, 3, 4, 4 };
        Console.Write($"Does array [{string.Join(", ", nums)}] contains duplicates: " +
                    (checkArrayDuplicates.IsArrayContainsDuplicate(nums) ? "YES\n" : "NO\n"));

        var longestCommonPrefix = new Leetcode.Problem014.LongestCommonPrefix();
        Console.WriteLine($"\n============================ {longestCommonPrefix.GetProblemTitle()} ============================");
        string[] strss = { "flower", "flow", "flight" };
        Console.WriteLine($"Longest Common Prefix is: \"{longestCommonPrefix.Find(strss)}\"");

        var rotateArray = new Leetcode.Problem189.RotateArray();
        Console.WriteLine($"\n============================ {rotateArray.GetProblemTitle()} ============================");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        rotateArray.RotateArr(arr, 3);
        Console.WriteLine($"Array after rotation: [{string.Join(", ", arr)}]");

        var checkSubsequence = new Leetcode.Problem392.StringSubsequence();
        Console.WriteLine($"\n============================ {checkSubsequence.GetProblemTitle()} ============================");
        string t1 = "ahbgdc";
        string s1 = "axc";
        Console.WriteLine($"Is string \"{s1}\" subsequence of \"{t1}\" => {checkSubsequence.IsGivenStringASubSequenceOfOther(s1, t1)}");

        var bstTimeToBuyAndSellStocks = new Leetcode.Problem121.BestTimeToBuyAndSellStocks();
        Console.WriteLine($"\n========== {bstTimeToBuyAndSellStocks.GetProblemTitle()} ===========");
        int[] stockPrices = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine($"Maximum profit gained during transaction = {bstTimeToBuyAndSellStocks.BestTimeToBuyStock(stockPrices)}");

        var faultyKeyboard = new Leetcode.Problem2810.FaultyKeyboard();
        Console.WriteLine($"\n============================ {faultyKeyboard.GetProblemTitle()} ============================");
        string faultKeyBoardString = "poiinter";
        Console.WriteLine($"String \"{faultKeyBoardString}\" after faulty keyboard input is: \"{faultyKeyboard.FaultyKeyboardFinalString(faultKeyBoardString)}\"");

        var reverseVowels = new Leetcode.Problem345.ReverseVowelsInString();
        Console.WriteLine($"\n============================ {reverseVowels.GetProblemTitle()} ============================");
        string test1 = "leetcode";
        Console.WriteLine($"String \"{test1}\" after reversing its vowel is: \"{reverseVowels.ReverseVowelOfAString(test1)}\"");

        var reverseString = new Leetcode.Problem344.ReverseString();
        Console.WriteLine($"\n============================ {reverseString.GetProblemTitle()} ============================");
        string test = "Hello";
        Console.WriteLine($"Reverse of string \"{test}\" is: \"{reverseString.Reverse(test)}\"");

        var twoSumSimple = new Leetcode.Problem001.TwoSumSimple();
        Console.WriteLine($"\n============================ {twoSumSimple.GetProblemTitle()} ============================");
        int[] arr1 = { 2, 7, 11, 15 };
        int[] simpleTwoSumIndex = twoSumSimple.GetTwoSumIndexes(arr1, 9);
        Console.WriteLine($"Array: {nameof(arr1)} has target on indexes: [{simpleTwoSumIndex[0]}, {simpleTwoSumIndex[1]}]");

        var twoSumII = new Leetcode.Problem167.TwoSumII();
        Console.WriteLine($"\n============================ {twoSumII.GetProblemTitle()} ============================");
        int[] array = { 2, 3, 4 };
        int[] twoSumIndex = twoSumII.GetTwoSumIndexes(array, 6);
        Console.WriteLine($"Array: {nameof(array)} has target on indexes: [{twoSumIndex[0]}, {twoSumIndex[1]}]");

        var checkCycleInLinkedList = new Leetcode.Problem141.CycleInLinkedList();
        Console.WriteLine($"\n============================ {checkCycleInLinkedList.GetProblemTitle()} ============================");
        var node1 = new Leetcode.Problem141.ListNode(1);
        var node2 = new Leetcode.Problem141.ListNode(2);
        var node3 = new Leetcode.Problem141.ListNode(3);
        var node4 = new Leetcode.Problem141.ListNode(4);

        // Creating a cycle
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        //node4.next = node2;

        // No Cycle
        node4.next = null;
        Console.WriteLine($"Linklist head {nameof(node1)} has cycle: {checkCycleInLinkedList.HasCycle(node1)}");

        var longestSubstringWithoutRepeatingChars = new Leetcode.Problem003.LongestSubstringWithoutRepeatingChars();
        Console.WriteLine($"\n============== {longestSubstringWithoutRepeatingChars.GetProblemTitle()} ================");
        string inputStr = "abcabcbb";
        // Case2: 
        //inputStr = "pwwkew";
        int lenOfLongestSubStr = longestSubstringWithoutRepeatingChars.LengthOfLongestSubstring(inputStr);
        Console.WriteLine($"Input Str: \"{inputStr}\": Length of Longest Substring: {lenOfLongestSubStr}");

        var climbStairs = new Leetcode.Problem070.ClimbStairs();
        Console.WriteLine($"\n============================ {climbStairs.GetProblemTitle()} ============================");
        int steps = climbStairs.DistinctWaysToClimbStairs(4);
        Console.WriteLine($"No of distinct ways to climb stairs are: {steps}");
    }
}