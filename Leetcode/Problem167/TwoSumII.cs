namespace ProblemSolvingPratice.Leetcode.Problem167;

internal class TwoSumII
{
    private string Title => "Leetcode 167. Two Sum II (Input Array is Sorted)";
    private string Url => "https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/";
    public string GetProblemTitle() => Title;
    public int[] GetTwoSumIndexes(int[] numbers, int target)
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
}
