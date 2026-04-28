public class MinStack {

    Stack<int> stack;
    List<int> minList;
    int min;

    public MinStack() {
        stack = new Stack<int>();
        minList = new List<int>();
        min = int.MaxValue;
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(val < min)
        min = val;
        minList.Add(min);
    }
    
    public void Pop() {
        if(stack.Count == 0 || minList.Count == 0) return;
        stack.Pop();
        minList.RemoveAt(minList.Count - 1);
        min = minList.Count >=1 ? minList[minList.Count - 1] : int.MaxValue;
    }
    
    public int Top() {
        if(stack.Count == 0) return 0;
        return stack.Peek();
    }
    
    public int GetMin() {
        return minList[minList.Count - 1];
    }
}
