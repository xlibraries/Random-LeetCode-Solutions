//Question Link:- https://leetcode.com/problems/remove-element
public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        //List<int> list = new List<int>();
        int j = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }
        // for(int i = 0; i < list.Count; i++)
        // {
        //     nums[i] = list[i];
        // }
        return j;
    }
}
