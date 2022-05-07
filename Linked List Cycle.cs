//Question Link:-https://leetcode.com/problems/linked-list-cycle/submissions/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return false;
        }
        ListNode prevNode = head;
        ListNode nextNode = head.next;
        while(prevNode != nextNode)
        {
            if(nextNode == null || nextNode.next == null)
            {
                return false;
            }
            prevNode = prevNode.next;
            nextNode = nextNode.next.next;
        }
        return true;
    }
}
