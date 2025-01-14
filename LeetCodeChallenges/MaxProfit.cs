namespace LeetCodeChallenges;
using System;

public class MaxProfit
{
    public static int CalculateMaxProfit(int[] prices) {
        int maxProfit = 0;
        if(prices.Length == 0) return maxProfit;
        int minPrice = -1;

        for(int i = 0; i < prices.Length; i++) {
            if (prices[i] < minPrice || minPrice == -1)
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit){
                maxProfit = prices[i] - minPrice;  
            }
        }

        return maxProfit;
    }
}