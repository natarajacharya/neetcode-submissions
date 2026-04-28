public class Solution {
    public int MaxArea(int[] heights) {
        
        int maxArea = Int32.MinValue;

        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {

            int tempArea = 0;

            tempArea = (right - left) * Math.Min( heights[right], heights[left]);

            maxArea = Math.Max(maxArea, tempArea);

            if(heights[left] < heights[right]) left++;
            else if(heights[left] > heights[right]) right--;
            else {
                left++;
                right--;
            }

        }

        return maxArea;

    }
}
