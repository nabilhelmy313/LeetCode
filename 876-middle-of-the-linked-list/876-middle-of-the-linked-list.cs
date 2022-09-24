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
public class Solution {
    public ListNode MiddleNode(ListNode head) {
          ListNode fast, slow;
    fast = head;
    slow = head;
    while (fast!=null && fast.next!=null)
    {
        //when fast in the last item slow item in the middle
        fast = fast.next.next;
        slow = slow.next;
    }
    return slow;
    }
}