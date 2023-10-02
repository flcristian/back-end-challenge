using remove_element;

internal class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 2, 2, 3 };
        int k = solution.RemoveElement(nums, 2);
        for (int i = 0; i < k; i++) Console.Write(nums[i] + " ");
    }
}