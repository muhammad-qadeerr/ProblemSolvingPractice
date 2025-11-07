namespace ProblemSolvingPratice.Leetcode.Problem070;

internal class ClimbStairs
{
    private string Title => "Leetcode 70. Climb Stairs";
    private string Url => "https://leetcode.com/problems/climbing-stairs/description/";
    public string GetProblemTitle() => Title;
    public int DistinctWaysToClimbStairs(int n)
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
}
