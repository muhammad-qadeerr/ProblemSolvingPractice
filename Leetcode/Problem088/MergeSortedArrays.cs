namespace ProblemSolvingPratice.Leetcode.Problem088;

internal class MergeSortedArrays
{
    private string Title => "Leetcode 88: Merge Sorted Array";
    private string Url => "https://leetcode.com/problems/merge-sorted-array/";
    public string GetProblemTitle() => Title;
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1; // Pointer for nums1 (excluding the trailing zeros)
        int j = n - 1; // Pointer for nums2
        int k = m + n - 1; // Pointer for inserting in nums1 from the end

        // Merge nums1 and nums2 from the back
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }

        // If nums2 is not fully merged, copy remaining elements
        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
    }
}

