namespace ProblemSolvingPratice.Leetcode.Problem344;

internal class ReverseString
{
    private string Title => "Leetcode 344. Reverse String";
    private string Url => "https://leetcode.com/problems/reverse-string/";
    public string GetProblemTitle() => Title;
    public string Reverse(string str)
    {
        if (string.IsNullOrEmpty(str)) return string.Empty;
        char[] chars = str.ToCharArray();
        int left = 0, right = str.Length - 1;

        while (left < right)
        {
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            left++; right--;
        }
        return new string(chars);
    }
}
