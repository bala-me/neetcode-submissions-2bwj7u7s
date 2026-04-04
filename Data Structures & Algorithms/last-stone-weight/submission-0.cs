public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        int x, y;

        foreach(int s in stones){
            maxHeap.Enqueue(-s,-s);
        }

        while(maxHeap.Count>1){
            x = maxHeap.Dequeue();
            y = maxHeap.Dequeue();

            if(x != y){
                int newWeight = x-y;
                maxHeap.Enqueue(newWeight, newWeight);
            }
           
        }
        maxHeap.Enqueue(0,0);
        return Math.Abs(maxHeap.Peek());
    }
}
