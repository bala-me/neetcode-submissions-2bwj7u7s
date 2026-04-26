public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length == 0)
            return 0;
        
        Array.Sort(nums);

        int res = 0;
        int current = nums[0];
        int streak = 0;
        int i = 0;
        while(i<nums.Length){
            if(current != nums[i]){
                streak = 0;
                current = nums[i];
            }
            while(i<nums.Length && current == nums[i]){
                i++;
            }
            streak++;
            current++;
            res = Math.Max(res, streak);
        }
        return res;
    }
}
