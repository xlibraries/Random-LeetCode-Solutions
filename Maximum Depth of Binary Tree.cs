//Question Link:-https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public int MaxDepth(TreeNode root) 
    {
        if(root == null)
        {
            return 0;
        }
        return Math.Max(MaxDepth(root.left) + 1,MaxDepth(root.right) + 1);
    }
}
