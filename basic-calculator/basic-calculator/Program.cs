using basic_calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.Calculate("(1+2)-(2+1)+3"));
    }
}