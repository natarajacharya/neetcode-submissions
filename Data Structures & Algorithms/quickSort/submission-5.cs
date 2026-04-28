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
    public List<Pair> QuickSort(List<Pair> pairs) {
        if(pairs == null || pairs.Count == 0) return new List<Pair>();

        Sort(pairs, 0, pairs.Count-1);
        return pairs;
    }

    public void Sort(List<Pair> pairs, int l, int r) {
        if(r - l + 1 <= 1) return;

        Pair pivot = pairs[r];
        int left = l;

        for(int i = l; i < r; i++ ) {
            if(pairs[i].Key < pivot.Key) {
                var temp = pairs[i];
                pairs[i] = pairs[left];
                pairs[left] = temp;

                left++;
            }
        }
        var temp1 = pairs[r];
        pairs[r] = pairs[left];
        pairs[left] = temp1;

        Sort(pairs, l, left-1);
        Sort(pairs, left+1, r);
    }
}
