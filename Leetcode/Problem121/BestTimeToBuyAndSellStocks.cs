namespace ProblemSolvingPratice.Leetcode.Problem121;

internal class BestTimeToBuyAndSellStocks
{
    private string Title => "LeetCode 121 - Best Time to Buy and Sell Stock -- Solved using Kandan Alogoritm";
    private string Url => "https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/";
    public string GetProblemTitle() => Title;
    public int BestTimeToBuyStock(int[] prices)
    {
        int buy = prices[0], profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < buy) { buy = prices[i]; }
            else if (prices[i] - buy > profit) { profit = prices[i] - buy; }
        }
        return profit;
    }
}

