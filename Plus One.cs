//QuesTion Link:- https://leetcode.com/problems/plus-one/submissions/
public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        int n = digits.Length;
        for (int i = digits.Length-1; i >= 0; i--)
        {
            if(digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] newNumber = new int[n + 1];
        newNumber[0] = 1;
        return newNumber;
    }
}
