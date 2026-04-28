// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> MergeSort(List<Pair> pairs) {

        if (pairs == null || pairs.Count == 0) {
            return new List<Pair>();
        }

        Sort(pairs, 0, pairs.Count - 1);
        return pairs;
    }

    public void Sort(List<Pair> pairs, int l, int r) {
        if (l == r) return;

        int m = (l + r)/2;
        Sort(pairs, l, m);
        Sort(pairs, m+1, r);
        Merge(pairs, l, m, r);
    }

    public void Merge(List<Pair> pairs, int l, int m, int r) {
        int leftLength = m - l + 1;
        int rightLength = r - m;

        List<Pair> leftList = new List<Pair>();
        List<Pair> rightList = new List<Pair>();

        for(int a = 0; a < leftLength; a++) {
            leftList.Insert(a, pairs[l + a]);
        }

        for(int b = 0; b < rightLength; b++) {
            rightList.Insert(b, pairs[m + 1 + b]);
        }

        int i = 0;
        int j = 0;
        int k = l;

        while(i < leftLength && j < rightLength) {
            if (leftList[i].Key <= rightList[j].Key) {
                pairs.RemoveAt(k);
                pairs.Insert(k, leftList[i]);
                i++;
            } else {
                pairs.RemoveAt(k);
                pairs.Insert(k, rightList[j]);
                j++;
            }
            k++;
        }
        while(i < leftLength) {
            pairs.RemoveAt(k);
            pairs.Insert(k, leftList[i]);
            i++;
            k++;
        }
        while(j < rightLength) {
            pairs.RemoveAt(k);
            pairs.Insert(k, rightList[j]);
            j++;
            k++;
        }

    }

}
