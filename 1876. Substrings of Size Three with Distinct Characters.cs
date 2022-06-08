//Question Link:- https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/submissions/

public class Solution {
    public int CountGoodSubstrings(string s) {
        
        if(s == null || s.Length < 3)
            return 0;
        
        int res = 0;
        for(int i = 1; i < s.Length - 1; i++)
        {
            if(s[i - 1] != s[i] && s[i] != s[i + 1] && s[i - 1] != s[i + 1])
                res++;
        }
        
        return res;
    }
}
