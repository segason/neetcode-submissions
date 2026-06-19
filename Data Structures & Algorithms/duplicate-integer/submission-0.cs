public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numsSet = new HashSet<int>(nums);
        return numsSet.Count < nums.Length;
    }
}