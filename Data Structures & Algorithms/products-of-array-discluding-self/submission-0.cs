public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] postfix = new int[nums.Length];
        int[] result = new int[nums.Length];

        int product = 1;
        for (int i = 0; i < nums.Length; i++) {
            product = product * nums[i];
            prefix[i] = product;
        }

        product = 1;

        for (int i = nums.Length - 1; i >= 0; i--) {
            product = product * nums[i];
            postfix[i] = product;
        }

        for(int i = 1 ; i < nums.Length-1; i++) {
            result[i] = prefix[i-1] * postfix [i+1];
        }
        result[0] = postfix[1];
        result[nums.Length-1] = prefix[nums.Length-2];

        return result;
    }
}
