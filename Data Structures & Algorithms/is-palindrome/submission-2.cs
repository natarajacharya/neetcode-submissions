public class Solution {
    public bool IsPalindrome(string s) {
        char[] str = s.ToArray();

        int i = 0;
        int j = str.Length-1;

        while (i < j) 
        {
            if(!Char.IsLetter(str[i]) && !Char.IsNumber(str[i])) 
            {
                i++;
                continue;
            }
            else if(!Char.IsLetter(str[j]) && !Char.IsNumber(str[j])) 
            {
                j--;
                continue;
            }
            else if(Char.ToLower(str[i]) == Char.ToLower(str[j]))
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
