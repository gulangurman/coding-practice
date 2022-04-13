/*
14. Longest Common Prefix

Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "". 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.
*/
public static partial class Solution {
    public static string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new StringBuilder();
        int i=0;
        string first = strs[0];
        if(first.Length==0) return "";
        bool done=false;        
            do{
                foreach(string s in strs){                   
                    if(s.Length==i || first.Length==i || s[i] != first[i])  done=true;                               
                }
                if(!done){
                    sb.Append(first[i]); 
                    i++; 
                }               
            }while(!done);        
        return sb.ToString();
    }
}             