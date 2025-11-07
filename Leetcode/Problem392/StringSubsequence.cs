namespace ProblemSolvingPratice.Leetcode.Problem392;

internal class StringSubsequence
{
    private string Title => "LeetCode 392: Is String a Subsequence";
    private string Url => "https://leetcode.com/problems/is-subsequence/";
    public string GetProblemTitle() => Title;
    public bool IsGivenStringASubSequenceOfOther(string s, string t)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j]) i++;
            j++;
        }
        return i == s.Length;
    }
}

