public class KthLargest {
private int k;

    PriorityQueue<int, int> minQueue;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        minQueue = new PriorityQueue<int, int>();
       
        foreach(int num in nums){
            minQueue.Enqueue(num, num);
            if(minQueue.Count>k){
                minQueue.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        minQueue.Enqueue(val, val);
        if(minQueue.Count>k){
                minQueue.Dequeue();
            }
            return minQueue.Peek();
    }
}
