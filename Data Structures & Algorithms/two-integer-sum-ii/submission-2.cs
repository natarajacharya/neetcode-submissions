public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];

        Dictionary<int, int> cache = new Dictionary<int, int>();
        
        int i = 0;

        while (i < numbers.Length) 
        {
            int sum = target - numbers[i];
            
            if(cache.ContainsKey(sum)) {
                result[0] = cache[sum] + 1;
                result[1] = i + 1;
                return result;
            } else {
                cache.Add(numbers[i], i);
            }
            i++;
        }
        return result;
    }
}
