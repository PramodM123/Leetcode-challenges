// First Unique Character in a String
/*
Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
Note: You may assume the string contain only lowercase letters.
*/
public class Solution {
    public int FirstUniqChar(string s) {
        var charr = new int[26];
        
        foreach(var i in s)
        {
            ++charr[i-'a'];
        }
        
        for(int j=0; j<s.Length; j++)
        {
            var ch = s[j];
            if(charr[ch-'a'] == 1)
            {
                return j;
            }
        }
        return -1;
    }
}