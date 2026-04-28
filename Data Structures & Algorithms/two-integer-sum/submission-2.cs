public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> result = new List<int>();
        
        for(int i = 0; i < nums.Length - 1; i++) {
            //if(nums[i] > target) continue;
            int temp = target - nums[i];
            for(int j = i + 1; j < nums.Length; j++) {
                if(nums[j] == temp) {
                    result.Add(i);
                    result.Add(j);
                    return result.ToArray();
                }
            }
        }
        return result.ToArray();
    }
}
