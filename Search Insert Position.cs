//Question Link:-https://leetcode.com/problems/search-insert-position/
public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        if(target <= nums[0])
        {
            return 0;
        }
        for(int i = 0; i < nums.Length - 1; i++)//0;1,3;
        {
            if(nums[i] <= target && nums[i+1] >= target)
            {
                if(target == nums[i])
                {
                    return i;
                }
                else
                {   
                    return i+1;
                    break;
                }
            }
        }
        return nums.Length;
    }
}
