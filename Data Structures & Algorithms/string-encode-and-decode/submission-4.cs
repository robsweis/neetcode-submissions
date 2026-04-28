public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach(string s in strs){
            sb.Append(s.Length + "#" + s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {

        int ptr = 0;

        char[] arr = s.ToCharArray();

        List<string> output = new List<string>();

        StringBuilder sb = new StringBuilder();

        while(ptr < arr.Length){

            int strCount = arr[ptr++] - '0';
            while(char.IsDigit(arr[ptr])){
                strCount = (strCount * 10) + (arr[ptr++] - '0'); 
            }

            ptr++;

            while(strCount > 0){
                sb.Append(arr[ptr++]);
                strCount--;
            }

            output.Add(sb.ToString());
            sb.Clear();
        }

        return output;
    }
}
