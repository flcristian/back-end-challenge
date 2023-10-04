namespace rotate_array;

public class Solution
{
    public void Swap(int[] nums, int i, int j)
    {
        int r = nums[i];
        nums[i] = nums[j];
        nums[j] = r;
    }
    
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        for (int i = 0, j = nums.Length - k - 1; i < j; i++, j--) Swap(nums, i, j);
        for (int i = nums.Length - k, j = nums.Length - 1; i < j; i++, j--) Swap(nums, i, j);
        for (int i = 0, j = nums.Length - 1; i < j; i++, j--) Swap(nums, i, j);
    }
}