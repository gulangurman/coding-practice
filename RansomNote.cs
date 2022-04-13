/*
383. Ransom Note

Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
Each letter in magazine can only be used once in ransomNote. 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
*/

public static partial class Solution {
    public static bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> rChars = new Dictionary<char, int>();
        foreach(char c in ransomNote){
            if(rChars.ContainsKey(c)){
                rChars[c] += 1;
            }else{
                rChars[c] = 1;
            }
        }
        Dictionary<char,int> mChars = new Dictionary<char, int>();
        foreach(char c in magazine){
            if(mChars.ContainsKey(c)){
                mChars[c] += 1;
            }else{
                mChars[c] = 1;
            }
        }
        foreach(var pair in rChars){
            if(!mChars.ContainsKey(pair.Key)) return false;
            if(mChars[pair.Key]<pair.Value) return false;
        }
        return true;
    }
}