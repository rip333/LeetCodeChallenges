namespace LeetCodeChallenges;

public class RemoveDuplicates
{
    public static int Remove(int[] nums)
    {
        int unique = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[unique])
            {
                unique++;
                nums[unique] = nums[i];
            }
        }
        return unique + 1;
    }
}