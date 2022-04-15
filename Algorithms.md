## Algorithm complexity and the use of asymptotic notation

Big O is for the upper bound on the running time of an algorithm as the input size gets bigger.
Remember to remove constants and smaller statements when calculating the complexity.

* O(1) : Very good, almost instant. Using a Set, Map, etc.
* O(logn) : Good. Binary search on a sorted array splits the input in half so its logarithmic.
* O(n) : Acceptable.
* O(nlogn) : Bad. Quicksort on an array.
* O(n^2),O(2^n),O(n!): Very bad. Avoid if possible.

## Sorting algorithms

1. Comparison based: Quicksort, Mergesort, Heapsort, Bubblesort, etc.
2. Non-comparison based: Specially designed for int/string types. Bucketsort, Radixsort, etc.

## Searching algorithms

1. Linear search: O(n). Processes each input.
2. Binary search: O(logn). Works only on sorted input. Must sort first.
3. Hash-based search: O(1). Works only on hashed input. Must hash first.

## Recursive algorithms

Used for calculating factorials, fibonacci numbers, tree traversal, graph search (DFS), etc. (Any recursive algo can be written iteratively.)

Issues:
* Hard to debug
* Base condition must be carefully designed
* Call stack might overflow on large input

## Dynamic programming

Improves efficiency of recursive algorithms by re-using solutions to subproblems. 
Think of it like caching previous results.
Helps reduce running time from exponential to linear. 
Downside is that it uses a lot of memory to cache results.

How to save sub-solutions:
* Tabulation: Bottom-up approach. Works faster.
* Memoization: Top-down approach. Easier to write.

Can be handy in solving some hard problems such as:
* Longest increasing subsequence
* Minimum edit distance
* Minimum coin return