using best_time_to_buy_and_sell_stock;

internal class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] prices = { 7,6,4,3,1 };
        Console.WriteLine(sol.MaxProfit(prices));
    }
}