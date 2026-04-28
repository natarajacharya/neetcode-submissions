/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {

        if(lists.Length == 0) {
            return null;
        }

        List<int> mainList = new List<int>();

        foreach(ListNode node in lists) {
            ListNode head = node;
            while(head != null) {
                mainList.Add(head.val);
                head = head.next;
            }
        }

        int[] mainArray = mainList.ToArray();

        MergeSort(mainArray, 0, mainList.Count - 1);
        ListNode sortedList = CreateTree(mainArray);
        return sortedList;
    }

    public ListNode CreateTree(int[] mainArray) {
        
        ListNode mainTree = new ListNode();
        ListNode temp = mainTree;
        
        foreach(int item in mainArray) {
            ListNode newNode = new ListNode(item);
            temp.next = newNode;
            temp = newNode;
        }

        return mainTree.next;
    }

    public void MergeSort(int[] arr, int l, int r) {
        if(l == r) return;
        int m = (l + r)/2;
        MergeSort(arr, l, m);
        MergeSort(arr, m+1, r);
        Merge(arr, l, m, r);
    }

    public void Merge(int[] arr, int l, int m, int r) {

        int leftLength = m - l + 1;
        int rightLength = r - m;

        int[] leftArray = new int[leftLength];
        int[] rightArray = new int[rightLength];

        for(int a = 0; a < leftLength; a++) {
            leftArray[a] = arr[l + a];
        }

        for(int b = 0; b < rightLength; b++) {
            rightArray[b] = arr[m + 1 + b];
        }

        int i = 0;
        int j = 0;
        int k = l;

        while(i < leftLength && j < rightLength) {
            if (leftArray[i] <= rightArray[j]) {
                arr[k] = leftArray[i];
                i++;
            } else {
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }
        while(i < leftLength) {
            arr[k] = leftArray[i];
            i++;
            k++;
        }
        while(j < rightLength) {
            arr[k] = rightArray[j];
            j++;
            k++;
        }

    }
}
