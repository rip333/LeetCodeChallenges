namespace LeetCodeChallengesTests;

public class MaxProfitTests
{
    [Fact]
    public void MaxProfit_Test_Case_1()
    {
        // Arrange
        int[] prices = { 7,1,5,3,6,4 };
        int expected = 5;

        // Act
        var response = MaxProfit.CalculateMaxProfit(prices);

        // Assert
        Assert.Equal(expected, response);
    }

    [Fact]
    public void MaxProfit_Test_Case_2()
    {
        // Arrange
        int[] prices = { 7,6,4,3,1 };
        int expected = 0;

        // Act
        var response = MaxProfit.CalculateMaxProfit(prices);

        // Assert
        Assert.Equal(expected, response);
    }

    [Fact]
    public void MaxProfit_Test_Case_3()
    {
        // Arrange
        int[] prices = { 2,4,1 };
        int expected = 2;

        // Act
        var response = MaxProfit.CalculateMaxProfit(prices);

        // Assert
        Assert.Equal(expected, response);
    }
}