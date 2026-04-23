public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        return nums.Length != set.Count;
    }
}