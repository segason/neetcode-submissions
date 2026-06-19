public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            var sIdx = s[i] - 'a';
            var tIdx = t[i] - 'a';
            count[sIdx]++;
            count[tIdx]--;
        }

        foreach (var occurence in count){
            if (occurence != 0)
                return false;
        }

        return true;
    }
}
