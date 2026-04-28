public class Solution {
    public bool IsPalindrome(string s) {

        int i = 0;
        int j = s.Length-1;

        while (i < j) 
        {
            if(!Char.IsLetter(s[i]) && !Char.IsNumber(s[i])) 
            {
                i++;
                continue;
            }
            else if(!Char.IsLetter(s[j]) && !Char.IsNumber(s[j])) 
            {
                j--;
                continue;
            }
            else if(Char.ToLower(s[i]) == Char.ToLower(s[j]))
            {
                i++;
                j--;
                continue;
            }
            return false;
        }
        return true;
    }
}
