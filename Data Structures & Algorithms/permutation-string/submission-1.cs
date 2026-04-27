public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if(s1.Length>s2.Length)
            return false;
            
        int[] count1 = new int[26];
        int[] count2 = new int[26];

        for(int i = 0;i<s1.Length;i++){
            count1[s1[i] - 'a']++;
            count2[s2[i] - 'a']++; 
        }
        if(count1.SequenceEqual(count2))
            return true;

        int left = 0;
        for(int right = s1.Length;right<s2.Length;right++){
            count2[s2[right]-'a']++;
            count2[s2[left]-'a']--;
            left++;
            if(count1.SequenceEqual(count2))
                return true;
        }

        return false;
    }
}
