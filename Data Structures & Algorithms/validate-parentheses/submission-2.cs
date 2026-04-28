public class Solution {
    public bool IsValid(string s) {
        Stack<char> left = new Stack<char>();
        foreach(char c in s.ToCharArray()) {
            if (c == '(' || c == '{' || c == '[') {
                left.Push(c); // Get left
            }
            // Compare to right:
            else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(') {
                left.Pop();
            } else if (c == '}' && left.Count != 0 && (char)left.Peek() == '{') {
                left.Pop();
            } else if (c == ']' && left.Count != 0 && (char)left.Peek() == '[') {
                left.Pop();
            } else {
                return false; // no match
            }
        }
        return left.Count == 0;
    }
}
