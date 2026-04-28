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
    public ListNode ReverseList(ListNode head) {

        if(head == null) return null;
        if(head.next == null) return head;

        ListNode temp = new ListNode();
        
        ListNode prev = new ListNode();
        prev.val = head.val;
        prev.next = null;

        head = head.next;

        while(head.next != null) {
            
            ListNode item = new ListNode();
            item.val = head.val;  
            item.next = prev;
            
            prev = item;

            head = head.next;
        }

        temp.val = head.val;
        temp.next = prev;

        return temp;
    }
}
