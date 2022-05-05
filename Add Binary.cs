//Question Link:-https://leetcode.com/problems/add-binary/
public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length-1; 
        int j = b.Length-1;
        int carry = 0;
        StringBuilder sb= new StringBuilder();
        while(i>=0 || j>=0){
            int sum= carry;
            if(i>=0){
                sum = sum+a[i--]-'0';
            }
            if(j>=0){
                sum = sum+b[j--]-'0';
            }
            sb.Insert(0, sum%2);
            carry = sum/2;
        }
        if(carry==1){
            sb.Insert(0,1);
        }
        return sb.ToString();
    }
}
