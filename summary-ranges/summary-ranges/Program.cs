using summary_ranges;

internal class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        List<string> result = sol.SummaryRanges(new[] { 0,2,3,4,6,8,9 }).ToList();
        result.ForEach(i => Console.WriteLine(i));
    }
}