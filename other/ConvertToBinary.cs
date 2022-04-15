/*
Given an integer, return the binary representation in string format. Use recursion.
E.g.:
Input:5
Output: "101"
*/
using System.Text;
public static partial class Solution{
	public static string ConvertToBinary(int num){	
		var result=new StringBuilder();	
		makeBinary(num,result);
		return result.ToString();
	}
	private static void makeBinary(int num, StringBuilder sb){
		if(num<2){ //base condition
			sb.Append(num);
			return; 
		} 		
		sb.Append(num%2);
		makeBinary(num/2,sb);
	}
}