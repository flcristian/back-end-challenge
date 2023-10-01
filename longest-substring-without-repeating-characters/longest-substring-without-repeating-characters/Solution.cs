public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 1) return 1;
        int max = 0;
        int left = 0;
        for (int right = 1; right < s.Length; right++)
        {
            for (int i = left; i < right; i++)
            {
                if (s[i] == s[right])
                {
                    left = i + 1;
                }
            }

            if (right - left + 1 > max)
            {
                max = right - left + 1;
            }
        }
        return max;
    }
}