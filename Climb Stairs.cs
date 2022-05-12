//Question Link:- https://leetcode.com/explore/learn/card/recursion-i/255/recursion-memoization/1662/
/*
    1 = 1; = 1
    2 = 1,1; 2; = 2
    3 = 1,1,1; 1,2; 2,1; = 2 + 1 = 3
    4 = 1,1,1,1; 1,1,2; 1,2,1; 2,1,1; 2,2; = 3 + 2  = 5
    5 = 1,1,1,1,1; 1,1,1,2; 1,1,2,1; 1,2,1,1; 2,1,1,1; 1,2,2; 2,1,2; 2,2,1; = 8
    
*/

public class Solution 
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    public int ClimbStairs(int n) 
    {
        if(dict.ContainsKey(n))
        {
            return dict[n];
        }
        int result = 0;
        if(n <= 2)
        {
            return n;
        }
        else
        {
            result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
        dict.Add(n, result);
        return result;
    }
}
