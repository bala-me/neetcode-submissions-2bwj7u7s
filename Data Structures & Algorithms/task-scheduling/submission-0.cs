public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> TasksCount = new  Dictionary<char, int>();

        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

        Queue<int[]> coolDownQueue = new Queue<int[]>();

        foreach(char task in tasks){
            if(!TasksCount.ContainsKey(task))
                TasksCount.Add(task, 0);
            TasksCount[task]++;
        }

        foreach(var value in TasksCount.Values){
            maxHeap.Enqueue(value, -value);
        }
        int time = 0;
        while(maxHeap.Count>0 || coolDownQueue.Count>0){
            if(coolDownQueue.Count>0 && time>=coolDownQueue.Peek()[1]){
                int[] temp = coolDownQueue.Dequeue();
                maxHeap.Enqueue(temp[0], -temp[0]);
            }
            if(maxHeap.Count>0){
                int cnt = maxHeap.Dequeue()-1;
                if(cnt>0)
                    coolDownQueue.Enqueue(new int[]{cnt, time+n+1});
            }
            time++;
        }
        return time;
    }
}
