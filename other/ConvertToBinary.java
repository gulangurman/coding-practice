/*
Given an integer, return the binary representation in string format. Use recursion.
E.g.:
Input:5
Output: "101"
*/
public class ConvertToBinary
{
    public static String convert(int num){	
		StringBuilder result=new StringBuilder();	
		makeBinary(num,result);
		return result.toString();
	}
	private static void makeBinary(int num, StringBuilder sb){
		if(num<2){ //base condition
			sb.append(num);
			return; 
		} 		
		sb.append(num%2);
		makeBinary(num/2,sb);
	}
    public static void main(String[] args) {
        System.out.println(convert(21));
    }
}