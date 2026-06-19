public class Solution {
    private Dictionary<char, int> CountMap(string word){
        var countMap = new Dictionary<char, int>();
        foreach(var wordChar in word){
            if (!countMap.ContainsKey(wordChar))
                countMap[wordChar] = 1;
            else
                countMap[wordChar]++;
        }

        return countMap;
    }

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sMap = CountMap(s);
        var tMap = CountMap(t);

        foreach (var sChar in s){
            if (!tMap.ContainsKey(sChar) || !sMap.ContainsKey(sChar)){
                return false;
            }
            else if (sMap[sChar] != tMap[sChar]){
                return false;
            }
        }
        return true;
    }
}
