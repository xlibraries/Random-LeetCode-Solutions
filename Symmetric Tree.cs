//Question Link:- https://leetcode.com/problems/symmetric-tree/submissions/
public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        if(root == null)
            return true;
        return helperCheck(root.left, root.right);
    }
    private bool helperCheck(TreeNode left, TreeNode right)
    {
        if(left == null || right == null)
        {
            return left == right;
        }
        if(left.val != right.val)
        {
            return false;
        }
        return helperCheck(left.left, right.right) && helperCheck(left.right, right.left);
    }
}
