//Question Link:-https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/930/
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
    List<int> result = new List<int>();
    public IList<int> PostorderTraversal(TreeNode root) 
    {
        if(root == null)
        {
            return result;
        }
        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        result.Add(root.val);
        return result;
    }
}
