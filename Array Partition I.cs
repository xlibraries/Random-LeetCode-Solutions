//Questions Link: https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1154/
public class Solution 
{
    public int ArrayPairSum(int[] nums) 
    {
        int sum = 0;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i += 2)
        {
            sum += nums[i];
        }
        return sum;
    }
}
