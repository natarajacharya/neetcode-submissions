public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if(s.Length == 1) return 1;

        List<char> cache = new List<char>();

        int left = 0;
        int right = 0;

        int result = Int32.MinValue;

        while(left <= right && right < s.Length) {
            while(cache.Contains(s[right])) {
                cache.RemoveAt(0);
                left++;
            }
                cache.Add(s[right]);
                result = Math.Max(result, right-left+1);

            right++;
        }
        
        if(result == Int32.MinValue) result = s.Length;

        return result;
    }
}
