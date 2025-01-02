namespace LeetCodeChallengesTests;
using System.Linq;

public class RemoveDuplicatesTests
{
    [Fact]
    public void RemoveDuplicates_Test_Case_1()
    {
        // Arrange
        int[] nums = { 1, 1, 2 };
        int expected = 2;
        
        // Act
        var actual = RemoveDuplicates.Remove(nums);

        // Assert
        Assert.Equal(expected, actual);
        Assert.Equal(new int[] { 1, 2 }, nums.Take(expected));
    }

    [Fact]
    public void RemoveDuplicates_Test_Case_2()
    {
        // Arrange
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int expected = 5;

        // Act
        var actual = RemoveDuplicates.Remove(nums);

        // Assert
        Assert.Equal(expected, actual);
        Assert.Equal(new int[] { 0, 1, 2, 3, 4 }, nums.Take(expected));
    }
}