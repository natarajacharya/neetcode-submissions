class ListedNode {
    public int value;
    public ListedNode prev;
    public ListedNode next;

    public ListedNode(int value = 0, ListedNode prev = null, ListedNode next = null ) {
        this.value = value;
        this.prev = prev;
        this.next = next;
    }

}

class Deque {

    ListedNode head;
    ListedNode tail;

    public Deque() {

    }

    public bool isEmpty() {
        return head == null;
    }

    public void append(int value) {
        if(tail == null) {
            tail = new ListedNode(value);
            head = tail;
        } 
        else {
            var temp = new ListedNode(value);
            tail.next = temp;
            temp.prev = tail;
            tail = temp;
        }
    }

    public void appendleft(int value) {
        if(head == null) {
            head = new ListedNode(value, null, null);
            tail = head;
        } else {
            var temp = new ListedNode(value);
            head.prev = temp;
            temp.next = head;
            head = temp;
        }
    }

    public int pop() {
        int val;
        if(tail == null) return -1;
        if(tail.prev == null) {
            val = tail.value;
            tail = null;
            head = null;
            return val;
        }
        val = tail.value;
        var temp = tail.prev;
        temp.next = null;
        tail = temp;
        return val;
    }

    public int popleft() {
        int val;
        if(head == null) return -1;
        if(head.next == null) {
            val = head.value;
            head = null;
            tail = null;
            return val;
        }
        val = head.value;
        var temp = head.next;
        temp.prev = null;
        head = temp;
        return val;
    }
}
