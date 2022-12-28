//Link: https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1167/
public class Solution 
{
    public int[] FindDiagonalOrder(int[][] mat) 
    {
        int m = mat.Length, n = mat[0].Length, row = 0, col = 0;
        int[] res = new int[m*n];
        
        for(int i = 0; i < res.Length; i++)
        {
			// set the output array
            res[i] = mat[row][col];
			
			// up
            if((row + col) % 2 == 0)
            {
				// check column first in case the top right element satisfy both col == n-1 and row == 0.
                if(col == n-1)
                    row++;
                else if(row == 0)
                    col++;
                else
                {
                    row--;
                    col++;
                }
            }
            else
            {  // down
			    // check row first in case the bottom left element satisfy both row == m-1 and col == 0.
                if(row == m-1)
                    col++;
                else if(col == 0)
                    row++;
                else
                {
                    row++;
                    col--;
                }
            }
        }
        return res;
    }
}
