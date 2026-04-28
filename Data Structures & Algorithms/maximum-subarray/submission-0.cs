public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length == 1) return nums[0];

        int maxSum = nums[0];
        int sum = 0;

        for(int r = 0; r < nums.Length ; r++) 
        {
            sum = Math.Max(sum, 0);
            sum = sum + nums[r];

            maxSum = Math.Max(maxSum, sum); 
        }
        return maxSum;
    }
}
