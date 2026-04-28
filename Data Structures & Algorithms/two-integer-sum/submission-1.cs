public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> indexes = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            indexes[nums[i]] = i; 
        }

        for(int i = 0; i < nums.Length; i++){
            int diffTarget = target - nums[i];

            if(indexes.ContainsKey(diffTarget) && indexes[diffTarget] != i){
                return new int[] {i, indexes[diffTarget]};
            }
        }

        return new int[0];
    }
}
