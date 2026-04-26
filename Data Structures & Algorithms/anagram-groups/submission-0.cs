public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<String, List<String>> result = new Dictionary<String, List<String>>();
        foreach(String str in strs){
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            String tempStr = new String(chars);
            if(!result.ContainsKey(tempStr)){
                result.Add(tempStr, new List<String>(){});
            }
            result[tempStr].Add(str);
        }
        List<List<String>> res = result.Values.ToList();
        return res;
    }
}