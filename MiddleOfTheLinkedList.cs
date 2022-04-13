/*
876. Middle of the Linked List

Given the head of a singly linked list, return the middle node of the linked list.
If there are two middle nodes, return the second middle node. 

Example 1:


Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
Example 2:


Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 

Constraints:

The number of nodes in the list is in the range [1, 100].
1 <= Node.val <= 100
*/

public static partial class Solution {
	public class ListNode {
	     public int val;
	     public ListNode next;
	     public ListNode(int val=0, ListNode next=null) {
	         this.val = val;
	         this.next = next;
	      }
	  }
    public static ListNode MiddleNode(ListNode head) {
        ListNode current = head;
        int count=0;
        while(current!=null){
            count++;
            current=current.next;
        }
        int midPoint = count/2;
        current=head;
        for(int i=0; i<midPoint; i++){
            current=current.next;
        }
        return current;
    }
}
