/*
13. Roman to Integer

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:

1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999].

*/
public partial class Solution {
    public static int RomanToInt(string s) {
        Dictionary<char,int> intValues = new Dictionary<char,int>();
        intValues.Add('I',1);
        intValues.Add('V',5);
        intValues.Add('X',10);
        intValues.Add('L',50);
        intValues.Add('C',100);
        intValues.Add('D',500);
        intValues.Add('M',1000);
        Dictionary<string,int> oddValues = new Dictionary<string,int>();
        oddValues.Add("IV",4);
        oddValues.Add("IX",9);
        oddValues.Add("XL",40);
        oddValues.Add("XC",90);
        oddValues.Add("CD",400);
        oddValues.Add("CM",900);
        int number=0;
        int i=0;
        while(i<s.Length-1){
            string str = s.Substring(i,2);
            if(oddValues.ContainsKey(str)){
                number += oddValues[str];
                i+=2;
            }else{
                number += intValues[str[0]];
                i++;
            }
        }
        if(i==s.Length-1){
            number += intValues[s[i]];
        }
        return number;
    }
}