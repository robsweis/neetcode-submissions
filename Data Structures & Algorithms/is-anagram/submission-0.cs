public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length){
            return false;
        }
        
        char[] charArrayS = s.ToCharArray();
        Array.Sort(charArrayS);

        char[] charArrayT = t.ToCharArray();
        Array.Sort(charArrayT);

        for(int i = 0; i < charArrayS.Length; i++){
            if(charArrayS[i] != charArrayT[i]){
                return false;
            }
        }

        return true;
    }
}
