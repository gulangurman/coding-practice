/*
Given a number n, print stairs of stars of n steps. Use recursion.

E.g.
Input: 4
Output:
*
**
***
****

*/
public static partial class Solution{
	public static void StarStairs(int num){
		PrintStairs(num);
		return;
	}
	private static void PrintStairs(int num){
		if(num==0){ //base condition			
			return; 
		}		
		PrintStairs(num-1);
		for(int i=0;i<num;i++){
			Console.Write("*");
		}
		Console.WriteLine();
	}
}