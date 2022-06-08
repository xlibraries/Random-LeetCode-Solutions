//Question Link:- https://leetcode.com/problems/find-the-k-beauty-of-a-number/submissions/

public class Solution 
{
      public int DivisorSubstrings(int num, int k)
    {
        int counter = 0;
        int sub = 0;
        int pow = 1;
        for (int n = num; n > 0; n /= 10)
        {
            sub += (n % 10) * pow;
            if (k > 1)  //Add the first K numbers
            { 
                pow *= 10;
                k--;
            }
            else //Create sub strings
            {
                if (sub != 0 && num % sub == 0)
                   counter ++ ;
                sub /= 10;
            }
        }

        return counter;
    }
}
