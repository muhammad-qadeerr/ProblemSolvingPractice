namespace ProblemSolvingPratice.Leetcode.Problem2810;

internal class FaultyKeyboard
{
    private string Title => "Leetcode 2810. Faulty Keyboard";
    private string Url => "https://leetcode.com/problems/faulty-keyboard/description/";
    public string GetProblemTitle() => Title;
    public  string FaultyKeyboardFinalString(string str)
    {
        string result = string.Empty;

        foreach (char c in str)
        {
            if (c == 'i')
            {
                result = ReverseString(result);
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
    private string ReverseString(string str)
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

