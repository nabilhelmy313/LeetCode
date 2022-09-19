public class Solution {
    public bool IsIsomorphic(string s, string t) {
          int size = 265;
    int m = s.Length;
    int n = t.Length;
    if (m != n)
        return false;
    // To mark visited characters in str2
    bool[] marked = new bool[size];

    for (int i = 0; i < size; i++)
        marked[i] = false;

    // To store mapping of every character
    // from str1 to that of str2 and
    // Initialize all entries of map as -1.
    int[] map = new int[size];

    for (int i = 0; i < size; i++)
        map[i] = -1;

    // Process all characters one by on
    for (int i = 0; i < n; i++)
    {

        // If current character of str1 is
        // seen first time in it.
        if (map[s[i]] == -1)
        {

            // If current character of str2
            // is already seen, one to
            // one mapping not possible
            if (marked[t[i]] == true)
                return false;

            // Mark current character of
            // str2 as visited
            marked[t[i]] = true;

            // Store mapping of current characters
            map[s[i]] = t[i];
        }

        // If this is not first appearance of current
        // character in str1, then check if previous
        // appearance mapped to same character of str2
        else if (map[s[i]] != t[i])
            return false;
    }
    return true;
    }
}