public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(count.ContainsKey(nums[i])){
                count[nums[i]] = count[nums[i]] + 1;
            }
            else{
                count.Add(nums[i], 1);
            }
        }

        var finalCount = count.OrderByDescending(kvp => kvp.Value);

        int[] output = new int[k];
        int j = 0;

        foreach(var item in finalCount){
            output[j] = item.Key;
            j++;

            if(j >= k){
                break;
            }
        }

        return output;
    }
}
