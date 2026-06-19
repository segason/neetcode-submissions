public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numsMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            numsMap[nums[i]] = i;
        }
        var result = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            var candidate = target - nums[i];
            if (numsMap.ContainsKey(candidate)){
                if (i != numsMap[candidate]){
                    result.Add(i);
                    result.Add(numsMap[candidate]);
                }
            }
        }

        return result.ToArray();
    }
}
