using majority_element;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        Console.WriteLine(sol.MajorityElement(nums));
    }
}