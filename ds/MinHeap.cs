/*
A Min Heap is a special complete binary tree where the root is always the minimum 
and each parent is smaller than its children.

When a new node is added, first it is inserted into the rightmost empty slot.
Then, the node bubbles up until we find a parent with a smaller value.

When a root node is removed the rightmost leaf is placed at root.
Then it propagates down, swapping with the smaller child until it becomes a leaf or
until it has no more smaller children.

Heaps are implemented with arrays.
For node n, the left child is at 2n and the right child is at 2n+1.

*/
public class MinHeap{
	
	public MinHeap(){		
	}


}