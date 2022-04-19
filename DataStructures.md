## Data Structures

1. Array

	Fixed size.
	Fixed type.
	Might be sparse and waste memory
	Cheap access O(1)
	Add/remove is expensive O(n)

	Example problems:
	* Find the repeating integer in an integer array: can be solved using a set or by sorting first, each has trade-offs
	* Find indices of two integers that add up to a given sum: can be solved using a hashmap

2. Linked List

	Each node has a value and a ref to another node.
	Cheap add/remove O(1)
	Access is expensive O(n)
	No index-based access. 
	Search is expensive O(n)

	Doubly linked list: has two refs (prev and next), so that we can move both ways.

	Example problems:
	* How can we remove an item from a singly linked list by doing a single traversal
	* Find if a linked list has a cycle



3. Map / Dictionary

	Has key-value pairs
	Commonly used to improve efficiency of algorithms (to eliminate the inner for loop)
	Add/remove is cheap O(1)
	Search is cheap O(1)
	Uses a hash function which groups elements in separate linked lists.

	Example problems:
	* Find the most frequent element in an unordered integer array

4. Stack

	Last in, first out
	Push/pop/peek are cheap O(1)
	Search expensive O(n)
	Indexed access expensive O(n)
	Commonly used to keep track of previous steps taken in an algorithm (called *backtracking*, like leaving breadcrumbs behind)
	Helpful when writing iterative version of a recursive algorithm, to replace the call stack(we can prevent stack overflow).

	Example problems:
	* Maze Runner: given a maze, develop an algorithm to find the exit 


5. Queue

	First in, first out
	Enqueue/dequeue/peek are cheap O(1)
	Search and indexed access expensive O(n)

	Example problems:
	* Implement queue ds with enqueue, dequeue, peek methods
	* Implement queue ds using linked list
	* LRU cache
	* Tree BFS
	* Graph shortest path BFS (e.g. shortest friendship path from two users in a social network)

6. Tree

	Parent-child relationship
	Search in O(logn) time

	Tree traversal can be: 
	* Depth-first (subtree-wise)
	* Breadth-first (level-wise)

	Depth first search can be: 
	* pre-order
	* in-order
	* post-order 
	depending on when we pass the root.

	To implement depth-first search we can
	* use recursion for an easy solution
	* use a stack to keep track of the nodes to be visited and iterate until stack is empty

	To implement breadt-first seearch we use a queue to keep track of the children to be visited at each level.

	Use DFS if you need to visit all nodes.
	Use BFS if you are looking for a path, or the tree is huge.

	Example problems:
	* Develop an algorithm to traverse a tree with pre-order DFS recursively
	* Develop an algorithm to traverse a tree with in-order DFS without using recursion (hint: use a stack)
	* Develop an algorithm to traverse a tree "vertically"
	* Print the top view of a binary tree
	* Find the closest common ancestor of two nodes

	Binary Tree: a special tree where each node has at most two children.
	 * Binary Search Tree(BST): a special binary tree where each node's value is bigger than all values in its left subtree, and smaller than its right subtree.
	 * Full binary tree: each node has 0 or 2 children
	 * Complete binary tree: each levels are full except the last
	 * Perfect binary tree: full and complete, that means all levels are full, no empty slots

	Example problems:
	* Find if a given tree is a binary search tree.
	* Given an ordered array, create a binary search tree
	* Find if a given tree is a full binary tree
	* Find if a given tree is a complete binary tree
	* Find if a given tree is a perfect binary tree


7. Heap (Min-heap, Max-heap)

	A min-heap is a special complete binary tree where the root is always the minimum 
	and each parent is smaller than its children.

	When a new node is added, first it is inserted into the rightmost empty slot.
	Then, the node bubbles up until we find a parent with a smaller value.

	When a root node is removed the rightmost leaf is placed at root.
	Then it propagates down, swapping with the smaller child until it becomes a leaf or
	until it has no more smaller children.

	Add/remove is in O(logn) time.
	Finds min/max in O(logn) time.

	Helpful in solving "find biggest, find smallest, find min./max n elements" type problems.

	Example questions: 
	* Find most frequent n words in a text
	* Find n people with most connections in a social network
	* Find if binary tree is a heap
	* Find if an array is a heap
	* Convert max-heap to min-heap

8. Graph
	
	Can be:
	* directed/undirected
	* connected/disconnected
	* cyclic/acyclic

	Tree is a special case of graphs since they are
	* connected
	* acyclic

	We use an adjacency list to list neighbors of each node.

	A graph can be traversed:
	* depth-first (subtree-wise)
	* breadth-first (level-wise)

	We mark a node as *visited* to avoid infinite loops during graph traversal.

	Use DFS if:
	* You need to visit all nodes

	Use BFS if:
	* You need to find a path
	* The graph is huge (e.g. find if two people are connected in a social network with millions of users)

	Example problems:
	* Find if a directed graph has a cycle
	* Find shortest path from node a to b
	* Topological sort: traverse all nodes that are connected in order
	* Minimum spanning tree: traverse all nodes in a weighted graph with minimum total edge cost