public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            char[] arr = strs[i].ToCharArray();

            Array.Sort(arr);

            string result = new string(arr);

            if(output.ContainsKey(result)){
                output[result].Add(strs[i]);
            }
            else{
                output.Add(result, new List<string> {strs[i]});
            }
        }

        List<List<string>> finalOutput = new List<List<string>>();

        foreach(string key in output.Keys){
            finalOutput.Add(output[key]);
        }

        return finalOutput;
    }
}
