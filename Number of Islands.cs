//Question Link:-https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1374/
public class Solution 
{
    int count = 0;
    public int NumIslands(char[][] grid) 
    {
        if(grid.Length == 0)
        {
            return 0;
        }
        for(int i =0 ; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    HelperCheck(grid,i,j);
                    count++;
                }
            }
        }
        return count;
    }
    private void HelperCheck(char[][]grid,int i,int j)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
        {
            return;
        }
        grid[i][j] = '0';
        HelperCheck(grid,i+1,j);
        HelperCheck(grid,i-1,j);
        HelperCheck(grid,i,j+1);
        HelperCheck(grid,i,j-1);
    }
}
