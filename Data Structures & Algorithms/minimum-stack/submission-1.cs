public class MinStack {

    public Stack<int> stack;
    public Stack<int> minStack;
    int val;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        
        stack.Push(val);

        if(minStack.Count == 0) {
            minStack.Push(val);
            return;
        }
        
        val = Math.Min(val, minStack.Peek());
        minStack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
