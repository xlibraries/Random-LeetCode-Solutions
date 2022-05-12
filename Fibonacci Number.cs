//Question LinK:-https://leetcode.com/explore/learn/card/recursion-i/255/recursion-memoization/1661/
public class Solution 
{
    Dictionary<int,int> dict = new Dictionary<int,int>();
    public int Fib(int n) 
    {
        if(dict.ContainsKey(n))
        {
            return dict[n];
        }
        int result = 0;
        if(n < 2)
        {
            return n;
        }
        else
        {
            result = Fib(n - 1) + Fib(n- 2);
        }
        dict.Add(n,result);
        return result;
        
    }
}
