//QuestionLink:- https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        HashSet<int> set = new HashSet<int>();
        int j = 0;
        for(int i = 0; i <nums.Length; i++)
        {
            if(set.Contains(nums[i]));
            else
            {
                nums[j] = nums[i];
                j++;
                set.Add(nums[i]);
            }
        }
        return set.Count;
    }
}
