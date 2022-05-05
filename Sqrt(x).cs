//Question Link:-https://leetcode.com/problems/sqrtx/submissions/
public class Solution 
{
    public int MySqrt(int x) 
    {
        //Truncate provides int part of a number
        int ans = Convert.ToInt32(Math.Truncate((Math.Sqrt(x))));
        return ans;
    }
}
