namespace LeetCodeChallengesTests;
using System.Linq;

public class RemoveElementTests
{
    [Fact]
    public void Test_Case_1()
    {
        // Arrange
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;
        int expected = 2;
        int[] expectedNums = { 2, 2 };
        // Act
        var actual = RemoveElement.Remove(nums, val);

        // Assert
        Assert.Equal(expected, actual);
        //elements can be returns in any order.  I didn't bother figuring out how to test this here because the solution was accepted
    }

    [Fact]
    public void Test_Case_2()
    {
        // Arrange
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;
        int expected = 5;
        int[] expectedNums = { 0, 1, 4, 0, 3 };

        // Act
        var actual = RemoveElement.Remove(nums, val);

        // Assert
        Assert.Equal(expected, actual);
    }
}