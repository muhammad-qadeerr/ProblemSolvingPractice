using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingPratice.Leetcode.Problem049;
internal class GroupAnagrams
{
    private string Title => "Leetcode 49: Group Anagrams";
    private string Url => "https://leetcode.com/problems/group-anagrams/";
    public string GetProblemTitle() => Title;

    public IList<IList<string>> GroupAnagramStrings(string[] strs)
    {
        var anagramMap = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new string(charArray);
            if (!anagramMap.ContainsKey(sortedStr))
            {
                anagramMap[sortedStr] = new List<string>();
            }
            anagramMap[sortedStr].Add(str);
        }
        return anagramMap.Values.ToList<IList<string>>();
    }
}

