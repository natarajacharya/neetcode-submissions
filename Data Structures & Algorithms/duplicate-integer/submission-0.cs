public class Solution {
    public bool hasDuplicate(int[] nums) {
        var distinctArray = nums.ToHashSet().ToArray();
        return distinctArray.Length != nums.Length;
    }
}
