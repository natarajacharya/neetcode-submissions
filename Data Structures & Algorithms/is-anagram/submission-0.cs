public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] arrayS = s.ToArray();
        Array.Sort(arrayS);
        char[] arrayT = t.ToArray();
        Array.Sort(arrayT);
         
        return new String(arrayS) == new String(arrayT);
    }
}
