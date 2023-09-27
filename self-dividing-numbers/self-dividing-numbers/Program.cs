using self_dividing_numbers;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();

        IList<int> list = sol.SelfDividingNumbers(1, 22);
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}