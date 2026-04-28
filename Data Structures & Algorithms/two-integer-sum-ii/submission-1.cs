public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];

        int i = 0;

        while (i < numbers.Length) 
        {
            int sum = target - numbers[i];
            int index = Array.IndexOf(numbers, sum);
            if( index > -1) 
            {
                result[0] = i + 1;
                result[1] = index + 1;
                return result;
            }
            i++;
        }
        return result;
    }
}
