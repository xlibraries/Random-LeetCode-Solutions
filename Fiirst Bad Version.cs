//Question Link:-https://leetcode.com/problems/first-bad-version
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) 
    {
        if(n == 1)
        {
            return n;
        }
        while(IsBadVersion(n))
        {
            n--;
        }
        Console.Write(n++);
        return n++;
    }
}
