namespace best_time_to_buy_and_sell_stock;

public class Solution {
    public int MaxProfit(int[] prices)
    {
        int min = prices[0], profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else if (prices[i] - min > profit)
            {
                profit = prices[i] - min;
            }
        }

        return profit;
    }
}