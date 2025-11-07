namespace ProblemSolvingPratice.Leetcode.Problem014;
internal class LongestCommonPrefix
{
    private string Title => "Leetcode 14. Longest Common Prefix";
    private string Url => "https://leetcode.com/problems/longest-common-prefix/description/";
    public string GetProblemTitle() => Title;
    public string Find(string[] strs)
    {
        if (strs == null || strs.Length == 0) return string.Empty;
        string prefix = strs[0];
        for (int i = 0; i < prefix.Length; i++)
        {
            char c = prefix[i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != c)
                {
                    return prefix.Substring(0, i);
                }
            }
        }
        return prefix;
    }
}
