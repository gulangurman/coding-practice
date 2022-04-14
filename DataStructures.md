## Data Structures

1. Array

	Fixed size.
	Fixed type.
	Might be sparse and waste memory
	Cheap access O(1)
	Add/remove is expensive O(n)

2. Linked List

	Each node has a value and a ref to another node.
	Cheap add/remove O(1)
	Access is expensive O(n)
	No index-based access. 
	Search is expensive O(n)
	Doubly linked list has two refs.

3. Map / Dictionary

	Has key-value pairs
	Commonly used to improve efficiency of algorithms (to eliminate the inner for loop)
	Add/remove is cheap O(1)
	Search is cheap O(1)
	Uses a hash function which groups elements in separate linked lists	

4. Stack

	Last in, first out
	Push/pop/peek are cheap O(1)
	Search expensive O(n)
	Indexed access expensive O(n)
	Commonly used to keep track of previous steps in an algorithm.
	(backtracking e.g. Maze Runner)
	Helpful when writing iterative version of a recursive algorithm.

5. Queue

	First in, first out
	Enqueue/dequeue/peek are cheap O(1)
	Search and indexed access expensive O(n)
	LRU cache, Tree BFS, Graph shortest path BFS, etc.

6. Tree

	Parent-child relationship
	Tree traversal can be: Depth-first or Breadth-first
	Depth first search can be: pre-order, in-order, post-order depending on when we pass the root
	

7. Heap

8. Graph

