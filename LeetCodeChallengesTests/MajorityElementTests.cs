namespace LeetCodeChallengesTests;
using System.Linq;

public class MajorityElementTests
{
    [Fact]
    public void MajorityElements_Test_Case_1()
    {
        // Arrange
        int[] nums = { 3, 2, 3 };
        int expected = 3;

        // Act
        var actual = MajorityElement.Find(nums);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MajorityElements_Test_Case_2()
    {
        // Arrange
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        int expected = 2;

        // Act
        var actual = MajorityElement.Find(nums);

        // Assert
        Assert.Equal(expected, actual);
    }
}