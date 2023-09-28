using top_k_frequent_elements;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 3, 0, 1, 0 };
        Solution sol = new Solution();


        foreach(int i in sol.TopKFrequent(nums,1).ToList())
        {
            Console.Write(i + " ");
        }
    }
}