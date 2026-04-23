public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach(int n in nums){
            if(!freq.ContainsKey(n))
                freq[n] = 0;
            freq[n]++;
        }

        foreach(var entry in freq){
            minHeap.Enqueue(entry.Key, -entry.Value);
        }
        List<int> result = new List<int>();
        while(k>0){
            result.Add(minHeap.Dequeue());
            k--;
        }
        return result.ToArray();
    }
}
