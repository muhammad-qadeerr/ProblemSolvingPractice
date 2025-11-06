using System.Collections.Generic;

namespace ProblemSolvingPratice.Leetcode.Problem242;
internal class ValidateAnagram
{
    private string Title => "Leetcode 242. Valid Anagram";
    private string Url => "https://leetcode.com/problems/valid-anagram/description/";
    public string GetProblemTitle() => Title;
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var freqS = new Dictionary<char, int>();
        var freqT = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (freqS.ContainsKey(c))
                freqS[c]++;
            else
                freqS[c] = 1;
        }
        foreach (char c in t)
        {
            if (freqT.ContainsKey(c))
                freqT[c]++;
            else
                freqT[c] = 1;
        }
        foreach (var kvp in freqS)
        {
            char key = kvp.Key;
            int value = kvp.Value;
            if (!freqT.TryGetValue(kvp.Key, out int count) || count != kvp.Value)
                return false;
        }
        return true;
    }
}
