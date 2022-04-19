/*
98. Validate Binary Search Tree

Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
 

Example 1:

Input: root = [2,1,3]
Output: true

Example 2:

Input: root = [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
 
Constraints:

The number of nodes in the tree is in the range [1, 104].
-231 <= Node.val <= 231 - 1

Definition for a binary tree node.
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
 public class ValidateBinarySearchTree{
    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
    
  public static bool isValid=true;
  private static void dfs(TreeNode current, int min, int max){   
       if((current.val >= max || current.val <= min)
          || (current.left  != null && current.left.val  >= current.val)
          || (current.right != null && current.right.val <= current.val)) {
      isValid = false; 
      return;
    }       
    if(current.left  != null) dfs(current.left,  min, current.val);
    if(current.right != null) dfs(current.right, current.val, max);    
  }
    public static bool IsValidBST(TreeNode root) {
      dfs(root, int.MinValue, int.MaxValue);      
      return isValid;
    }
    
 }
