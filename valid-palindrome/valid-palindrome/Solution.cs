using System.Net.Mime;

namespace valid_palindrome;

public class Solution {
    private bool IsValidCharacter(char character)
    {
        int val = Convert.ToByte(character);
        return (val > 47 && val < 58) || (val > 96 && val < 123);
    }
    
    public bool IsPalindrome(string text)
    {
        text = text.ToLower();
        for (int i = 0, j = text.Length - 1; i < j; i++, j--)
        {
            while (i < j && !IsValidCharacter(text[i])) i++;
            while (i < j && !IsValidCharacter(text[j])) j--;
            if (text[i] != text[j]) return false;
        }

        return true;
    }
}