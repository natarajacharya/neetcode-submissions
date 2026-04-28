// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> pairOfPairs = new List<List<Pair>>();
        //pairOfPairs.Add(pairs);

        for(int i = 0; i < pairs.Count; i++ ) {
            for(int j = i-1; j >=0; j--) {
                if(pairs[j].Key > pairs[j+1].Key){
                    Pair temp = pairs[j];
                    pairs[j] = pairs[j+1];
                    pairs[j+1] = temp;
                }          
            }
            List<Pair> tempList = new List<Pair>(pairs);
            pairOfPairs.Add(tempList);
        }

        return pairOfPairs;
    }
}

