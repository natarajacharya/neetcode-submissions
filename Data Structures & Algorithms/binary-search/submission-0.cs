public class Solution {
    public int Search(int[] nums, int target) {
        if(nums == null || nums.Length == 0) return -1;
        
        int left = 0, right = nums.Length-1;

        while(left <= right) {
           int mid = (left + right)/2;

           if(nums[mid] > target) {
               right = mid - 1;
           }
           else if (nums[mid] < target) {
               left = mid + 1;
           }
           else return mid;
        }

        return -1;
    }
}
