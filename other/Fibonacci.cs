/*
Given an integer n, calculate the fibonacci number of n.
E.g.
fib(2)=1
fib(6)=8
*/
public class Fibonacci{
	public static int FibonacciRecursive(int n)
	{
		if(n==0 || n==1) return n;
		return FibonacciRecursive(n-1)+FibonacciRecursive(n-2);
	}
	// Memoization: cache prev results to avoid repetitive recursive calls
	public static int FibonacciDPTopDown(int n, Dictionary<int,int> memo)
	{
		if(memo.ContainsKey(n)) return memo[n];
		if(n==0 || n==1){ memo[n]=n; return n; }
		memo[n] = fib(n-1, memo) + fib(n-2, memo);
		return memo[n];	
	}
	// Tabulation : fill the table to solve
	public static int FibonacciBottomUp(int n)
	{
		int[] memo = new int[n + 1];
		memo[0] = 0;
		memo[1] = 1;
		for (int i = 2; i <= n; i++)
		{
			memo[i] = memo[i - 1] + memo[i - 2];
		}
		return memo[n];
	}
}