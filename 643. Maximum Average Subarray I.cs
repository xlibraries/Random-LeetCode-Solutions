//Question Link:- https://leetcode.com/problems/maximum-average-subarray-i/submissions/

public class Solution 
{
    public double FindMaxAverage(int[] nums, int k)
        {
            int currSum = nums.Take(k).Sum();
            double max =  currSum / (double)k;
            for (int i = k; i < nums.Length; i++)
            {
                currSum -= nums[i - k];
                currSum += nums[i];
                max = Math.Max(max, currSum / (double) k);
            }

            return max;
        }
}
