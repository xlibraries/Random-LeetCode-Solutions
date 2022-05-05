//Question Link:-https://leetcode.com/problems/remove-duplicates-from-sorted-list/submissions/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return head;
        }
        ListNode currNode = head;
        while(currNode.next != null)
        {
            if(currNode.val == currNode.next.val)
            {
                currNode.next = currNode.next.next;
            }
            else
            {
                currNode = currNode.next;
            }
        }
        return head;
    }
}
