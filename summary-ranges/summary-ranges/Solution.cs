namespace summary_ranges;

public class Solution {
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new List<string>();
        if (nums.Length > 0)
        {
            int start = nums[0], last = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != last + 1)
                {
                    if (last == start) result.Add($"{start}");
                    else result.Add($"{start}->{nums[i - 1]}");
                    start = nums[i];
                }

                last = nums[i];
            }
            if (last == start) result.Add($"{start}");
            else result.Add($"{start}->{last}");
        }
        return result;
    }
}