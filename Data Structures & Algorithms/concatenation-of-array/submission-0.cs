public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int numsLength = nums.Length;
        int[] result = new int[2 * numsLength]; 
        
        for(int i = 0; i < numsLength; i++) {
            result[i] = nums[i];
            result[i + numsLength] = nums[i];
        }

        return result;
    }
}