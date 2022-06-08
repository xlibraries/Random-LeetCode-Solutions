//Question Link:- https://leetcode.com/problems/remove-palindromic-subsequences/submissions/

public class Solution 
{
    public int RemovePalindromeSub(string s) 
    {
        if(s.Length == 0)
        {
            return 0;
        }
        else if(IsPalindrome(s))
        {
            return 1;
        }
        return 2;
    }
    
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length-1;
        while(left < right)
        {
            if(s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
