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
public class StarStairs{	
	public static void printStairs(int num){
		if(num==0) return; //base condition
		printStairs(num-1);
		for(int i=0;i<num;i++){
			System.out.print("*");
		}
		System.out.println();
	}
}