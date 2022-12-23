public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int cons = 0;
        int curr = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                curr++;
                if(cons < curr)
                {
                    cons = curr;
                }
            }
            else
            {
                curr = 0;
            }
        }
        return cons;
    }
}
