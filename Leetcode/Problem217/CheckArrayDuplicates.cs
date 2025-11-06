using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPratice.Leetcode.Problem217;

internal class CheckArrayDuplicates
{
    private string Title => "Leetcode 217: Contains Duplicate";
    private string Url => "https://leetcode.com/problems/contains-duplicate/description/";
    public string GetProblemTitle() => Title;
    public bool IsArrayContainsDuplicate(int[] nums)
    {
        //var uniqueElements = new HashSet<int>();  // HashSet always contain unique elements
        //foreach (int ele in nums)
        //{
        //    uniqueElements.Add(ele);
        //}
        return new HashSet<int>(nums).Count < nums.Length;
    }
}

