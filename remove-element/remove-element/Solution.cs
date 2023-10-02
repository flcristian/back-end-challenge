namespace remove_element;

public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0, k = nums.Length;
        while (i < k)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[k - 1];
                k--;
            }
            else i++;
        }

        return k;
    }
}