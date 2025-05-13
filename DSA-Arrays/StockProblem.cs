namespace DSA_Arrays;
class StockProblem
{
    /*
     * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
     * 121. Best Time to Buy and Sell Stock
     */
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int buyingPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            buyingPrice = Math.Min(buyingPrice, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - buyingPrice);
        }
        return maxProfit;
    }
    /*
     * https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
     * 122. Best Time to Buy and Sell Stock II
     */
    public int MaxProfit2(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 1; i < prices.Length;i++)
        {
            if (prices[i] > prices[i-1])
            {
                maxProfit += prices[i] - prices[i - 1];
            }
        }
        return maxProfit;
    }
}


