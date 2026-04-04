public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqArray = new Dictionary<int, int>();
        foreach(int num in nums){
            if(!freqArray.ContainsKey(num)){
                freqArray[num] = 1;
            }
            else{
                freqArray[num]++;
            }
        }

        var newDict = freqArray.OrderByDescending(val => val.Value);

        int cnt = 1;
        List<int> result = new List<int>();
        foreach(var val in newDict){
            if(cnt>k){
                break;
            }
            result.Add(val.Key);
            cnt++;
        }
        return result.ToArray();
    }
}
