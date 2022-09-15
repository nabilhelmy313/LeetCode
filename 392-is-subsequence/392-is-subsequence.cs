public class Solution {
    public bool IsSubsequence(string s, string t) {
       int index = 0;
        foreach (var val in t)
        {
            if (index == s.Length)
                break;
            if (s[index] == val)
                index++;
        }
        return index == s.Length;
    }
}