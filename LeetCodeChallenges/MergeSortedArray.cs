namespace LeetCodeChallenges;
using System;

public class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0) return;

        if (m == 0)
        {
            for(int i = 0; i < n; i++) {
                nums1[i] = nums2[i];
            }
            return;
        }

        int lastElement = n + m - 1;
        int lastM = m - 1;
        int lastN = n - 1;

        while (lastN >= 0 && lastM >= 0) {
            if (nums1[lastM] > nums2[lastN]) {
                nums1[lastElement--] = nums1[lastM--];
            }
            else {
                nums1[lastElement--] = nums2[lastN--];
            }
        }

        while (lastN >= 0) {
            nums1[lastElement--] = nums2[lastN--];
        }
    }
}
