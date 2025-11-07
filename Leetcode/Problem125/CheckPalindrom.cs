using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProblemSolvingPratice.Leetcode.Problem125;

internal class CheckPalindrom
{
    private string Title => "125. Valid Palindrome";
    private string Url => "https://leetcode.com/problems/valid-palindrome/description/";
    public string GetProblemTitle() => Title;
    public bool IsPalindrome(string s)
    {
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        Stack<char> stack = new Stack<char>();
        string result = string.Empty;

        foreach (char c in s) { stack.Push(c); }

        foreach (char c in s)
        {
            if (stack.Pop() != c)
            {
                return false;
            }
        }
        return true;
    }
}
