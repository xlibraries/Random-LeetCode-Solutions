//Question Link:- https://leetcode.com/problems/length-of-last-word/
public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        int length = 0;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] == ' ' && length > 0)
            {
                break;
            }
            if(s[i] == ' ')
            {
                
            }
            else
            {
                length++;   
            }
        }
        return length;
    }
}
