/*
94. Binary Tree Inorder Traversal

Given the root of a binary tree, return the inorder traversal of its nodes' values.

Example 1:

Input: root = [1,null,2,3]
Output: [1,3,2]
Example 2:

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
public class BinaryTreeInorderTraversal {
    public static IList<int> InorderTraversal(BinaryTreeNode root) {
        List<int> result = new List<int>();
        if(root!=null) traverse(root,result);        
        return result;
    }
    private static void traverse(BinaryTreeNode current, List<int> result){
        if(current.left!=null) traverse(current.left, result);
        if(current.val!=null) result.Add(current.val);
        if(current.right!=null)traverse(current.right, result);
    }
}