namespace ProblemSolvingPratice.Leetcode.Problem189;

internal class RotateArray
{
    private string Title => "Leetcode 189. Rotate Array";
    private string Url => "https://leetcode.com/problems/rotate-array/";
    public string GetProblemTitle() => Title;
    public void RotateArr(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return;
        k = k % nums.Length;
        if (k == 0) return;
        ReverseArrayFromSpecificIndexes(nums, 0, nums.Length - 1);
        ReverseArrayFromSpecificIndexes(nums, 0, k - 1);
        ReverseArrayFromSpecificIndexes(nums, k, nums.Length - 1);
    }
    private void ReverseArrayFromSpecificIndexes(int[] arr, int left, int right)
    {
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++; right--;
        }
    }
}

