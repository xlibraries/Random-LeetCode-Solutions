public class Solution 
{
    public int[] SortArrayByParity(int[] nums) 
    {
        int even = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0)
            {
                int temp = nums[even];
                nums[even] = nums[i];
                nums[i] = temp;
                even++;
            }
        }
        return nums;
    }
}
