//Question Link:-https://leetcode.com/problems/middle-of-the-linked-list/submissions/
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
    public ListNode MiddleNode(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return head;
        }
        ListNode prevNode = head;
        ListNode nextNode = head.next;
        while(nextNode != null)
        {
            prevNode = prevNode.next;
            if(nextNode.next == null)
            {
                break;
            }
            nextNode = nextNode.next.next;
        }
        return prevNode;
    }
}
