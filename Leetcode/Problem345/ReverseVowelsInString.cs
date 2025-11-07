namespace ProblemSolvingPratice.Leetcode.Problem345;

internal class ReverseVowelsInString
{
    private string Title => "Leetcode 345. Reverse Vowels of a String";
    private string Url => "https://leetcode.com/problems/reverse-vowels-of-a-string/";
    public string GetProblemTitle() => Title;
    public string ReverseVowelOfAString(string str)
    {
        if (string.IsNullOrEmpty(str)) return string.Empty;
        char[] chars = str.ToCharArray();
        int left = 0, right = str.Length - 1;

        string vowels = "aeiouAEIOU";
        while (left < right)
        {
            while (left < right && !vowels.Contains(chars[left]))
            { left++; }
            while (left < right && !vowels.Contains(chars[right]))
            { right--; }

            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            left++; right--;
        }
        return new string(chars);
    }
}

