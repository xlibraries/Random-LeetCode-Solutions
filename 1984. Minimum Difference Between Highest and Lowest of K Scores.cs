//Question Link:- https://leetcode.com/problems/minimum-difference-between-highest-and-lowest-of-k-scores/submissions/

public class Solution 
{
    public int MinimumDifference(int[] nums, int k) 
    {
    	if(k == 1)
	    {
		    return 0;        
	    }

    	Array.Sort(nums);
	    int result = int.MaxValue;

    	for(int i = 0; i < nums.Length - k + 1; i++)
	    {
		    int diff = nums[i + k - 1] - nums[i];
    		result = Math.Min(result, diff);            
	    }

	    return result;
    }
}
