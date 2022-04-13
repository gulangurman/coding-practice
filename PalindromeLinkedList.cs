/*
234. Palindrome Linked List

Given the head of a singly linked list, return true if it is a palindrome.

Example 1:
Input: head = [1,2,2,1]
Output: true

Example 2:
Input: head = [1,2]
Output: false
 
Constraints:
The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9 

Follow up: Could you do it in O(n) time and O(1) space?
*/
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
 public static partial class Solution {
	  class ListNode {
	      public int val;
	      public ListNode next;
	      public ListNode(int val=0, ListNode next=null) {
	          this.val = val;
	          this.next = next;
	      }
	  }
    public static bool IsPalindrome(ListNode head) {
        List<int> values = new List<int>();
        ListNode current=head;
        do{
            values.Add(current.val);
            current=current.next;
        }while(current != null);
        current=head;
        for(int i=values.Count-1; i>= (values.Count+1)/2; i--){
            if(current.val != values[i]){
                return false;
            }
            current = current.next;
        }
        return true;
    }
}