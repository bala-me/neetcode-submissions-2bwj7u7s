public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> compliments = new Dictionary<int, int>();
        int compliment;
        for(int i = 0;i<nums.Length;i++){
            compliment = target - nums[i];
            if(compliments.ContainsKey(compliment)){
                return new int[]{compliments[compliment], i};
            }
            compliments.Add(nums[i], i);
        }
        return new int[]{};
    }
}
