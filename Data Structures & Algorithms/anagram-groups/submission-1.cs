public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<string> sortedStrings = new List<string>();

        Dictionary<string, List<string>> map = new Dictionary <string, List<string>>();

        foreach(string str in strs) {
            char[] temp = str.ToArray();
            Array.Sort(temp);
            sortedStrings.Add(new String(temp));
        }

        for(int i = 0; i < sortedStrings.Count; i++) {
            if (map.ContainsKey(sortedStrings[i])) {
                map[sortedStrings[i]].Add(strs[i]);
            } else
            map.Add(sortedStrings[i], new List<string>{strs[i]});
        }

        return new List<List<string>>(map.Values);
    }
}
