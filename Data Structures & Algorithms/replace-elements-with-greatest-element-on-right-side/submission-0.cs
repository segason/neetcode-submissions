public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var result = new int[arr.Length]; 
        for (int i = 0; i < arr.Length - 1; i++){
            var rightMax = arr[i + 1];
            for (int j = i + 2; j < arr.Length; j++){
                if (rightMax < arr[j]){
                    rightMax = arr[j];
                }
            }
            result[i] = rightMax;
        }

        result[result.Length - 1] = -1;
        return result;
    }
}