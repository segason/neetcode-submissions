public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var n = 0;
        var maxConsecutive = 0;
        foreach (var num in nums){
            if (num == 1)
                n += 1;
            if (num == 0){
                maxConsecutive = n > maxConsecutive ? n : maxConsecutive;
                n = 0;
            }
        }
        return n > maxConsecutive ? n : maxConsecutive;
    }
}