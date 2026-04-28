public class MinStack {

    Stack<int> stack;
    List<int> minList;

    public MinStack() {
        stack = new Stack<int>();
        minList = new List<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minList.Count >=1 && minList[minList.Count - 1] < val)
            minList.Add(minList[minList.Count - 1]);
        else 
            minList.Add(val);
    }
    
    public void Pop() {
        if (stack.Count == 0 || minList.Count == 0) return;
        stack.Pop();
        minList.RemoveAt(minList.Count - 1);
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minList[minList.Count - 1];
    }
}
