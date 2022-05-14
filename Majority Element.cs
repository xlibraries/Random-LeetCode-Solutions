//Question Link:-https://leetcode.com/problems/majority-element/submissions/
public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        int count = 0;
        int candidate = nums[0];

        foreach (int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }
}
