using System.Collections.Generic;

namespace ProblemSolvingPratice.Leetcode.Problem001;

internal class TwoSumSimple
{
    private string Title => "Leetcode 1. Two Sum";
    private string Url => "https://leetcode.com/problems/two-sum/description/";
    public string GetProblemTitle() => Title;
    public int[] GetTwoSumIndexes(int[] nums, int target)
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
}
