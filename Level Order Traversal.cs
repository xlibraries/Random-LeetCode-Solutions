//Question Link:-https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/931/
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
    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        IList<IList<int>> result = new List<IList<int>>();
        if(root == null)
        {
            return result;
        }
        result.Add(new List<int>(){root.val});
        TraverseTree(root.left,result);
        TraverseTree(root.right,result);
        return result;
    }
    
    private void TraverseTree(TreeNode root, IList<IList<int>> result, int depth = 0)
    {
        if(root == null)
        {
            return;
        }
        if(result.Count == ++depth)
        {
            result.Add(new List<int>());
        }
        result[depth].Add(root.val);
        TraverseTree(root.left,result,depth);
        TraverseTree(root.right,result,depth);
    }
}
