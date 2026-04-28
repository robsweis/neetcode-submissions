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

        var sortedValues = count.OrderByDescending(x => x.Value)
                               .Select(x => x.Key)
                               .ToList();


        int[] output = new int[k];

        for(int i = 0; i < k; i++){
            output[i] = sortedValues[i];
        }

        return output;
    }
}
