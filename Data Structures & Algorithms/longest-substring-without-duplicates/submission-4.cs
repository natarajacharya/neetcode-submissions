public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;

        HashSet<char> cache = new HashSet<char>();

        int maxLength = int.MinValue;

        int L = 0;
        int R = 0;

        while (R < s.Length) 
        {
            if (!cache.Contains(s[R])) {
                cache.Add(s[R]);
                maxLength = Math.Max( maxLength, R - L + 1);
            }
            else {
                while (L <= R) {
                    if(s[L] != s[R]) {
                    cache.Remove(s[L]);
                    L++;
                    }
                    else {
                        L++;
                        break;
                    }
                }
            }
            R++;
        }
        return maxLength;
    }
}
