namespace LeetCodeChallenges;

public class RemoveElement
{
    public static int Remove(int[] nums, int val)
    {
        int hits = 0;
        int misses = 0;
        int[] missList = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == val) {
                hits++;
            }
            else {
                missList[misses++] = nums[i];
            }
        }

        for(int i = 0; i < nums.Length - hits; i++) {
            nums[i] = missList[i];
        }

        return misses;
    }
}