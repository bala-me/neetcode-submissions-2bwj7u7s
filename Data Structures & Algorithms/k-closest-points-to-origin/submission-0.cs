public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        double distance;

        PriorityQueue<int[], double> minHeap = new PriorityQueue<int[], double>();

        foreach(int[] point in points){
            distance = Math.Sqrt(point[0] * point[0] + point[1] * point[1]);
            Console.WriteLine($"Distance between {point[0]} {point[1]} {point[0]^2} {point[0]^2} {point[1]^2 + point[1]^2} is {distance}");
            minHeap.Enqueue(new int[]{point[0], point[1]}, -distance);
            if(minHeap.Count>k)
                minHeap.Dequeue();
        }
        int index = 0;
        int[][] result = new int[minHeap.Count][];
        while(minHeap.Count>0){
            result[index] = minHeap.Dequeue();
            index++;
        }
        return result;
    }
}
