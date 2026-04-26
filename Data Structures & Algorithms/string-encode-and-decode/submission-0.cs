public class Solution {

    public string Encode(IList<string> strs) {
        string result = String.Empty;

        foreach(string str in strs){
            result += str.Length +"#" + str;
        }
        Console.WriteLine(result);

        return result;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;

        while(i<s.Length){
        int j = i;
        int len;
        string temp;
        while(s[j] != '#'){
            j++;
        }

        len = int.Parse(s.Substring(i, j-i));
        temp = s.Substring(j+1, len);
        Console.WriteLine(temp);
        res.Add(temp);
        j=j+len+1;
        i=j;
        Console.WriteLine(len);
        }
        return res;

        
   }
}
