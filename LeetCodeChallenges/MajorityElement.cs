namespace LeetCodeChallenges;
using System;

public class MajorityElement
{
    public static int Find(int[] nums)
    {
        int majorityElement = nums[0];
        if (nums.Length == 1) return majorityElement;
        Dictionary<int, int> elements = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (elements.ContainsKey(nums[i])) {
                elements[nums[i]]++;
                if(elements[nums[i]] > nums.Length/2) {
                    return nums[i];
                }
            }
            else {
                elements.Add(nums[i], 1);
            }
        }
        return majorityElement;
    }
}