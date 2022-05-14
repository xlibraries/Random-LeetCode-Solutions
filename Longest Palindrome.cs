//Question Link:-https://leetcode.com/problems/longest-palindrome/submissions/
public class Solution 
{
    public int LongestPalindrome(string s) 
    {
        if(s.Length == 1)
        {
            return 1;
        }
        HashSet<char> Set = new HashSet<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(Set.Contains(s[i]))
            {
                Set.Remove(s[i]);
            }
            else
            {
                Set.Add(s[i]);
            }
        }
        if(Set.Count == 0 || Set.Count == 1)
        {
            return s.Length;
        }
            return s.Length - Set.Count + 1;
    }
}
