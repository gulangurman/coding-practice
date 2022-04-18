/*
144. Binary Tree Preorder Traversal

Given the root of a binary tree, return the preorder traversal of its nodes' values.

Example 1:

Input: root = [1,null,2,3]
Output: [1,2,3]
E
xample 2:

Input: root = []
Output: []

Example 3:

Input: root = [1]
Output: [1]
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
 

Follow up: Recursive solution is trivial, could you do it iteratively?
*/
public class BinaryTreePreorderTraversal {
    public static IList<int> PreorderTraversal(BinaryTreeNode root) {
      List<int> result=new List<int>();
      traverse(root,result);
      return result;
    }
  private static void traverse(BinaryTreeNode current, List<int> result){
    if(current==null || current.val==null) return;
    result.Add(current.val);
    traverse(current.left, result);
    traverse(current.right, result);
  }
}
