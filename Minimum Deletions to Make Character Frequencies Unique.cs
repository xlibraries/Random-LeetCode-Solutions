public class Solution 
{
    public int MinDeletions(string s) 
    {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        List<int> check = new List<int>();
        int count = 0;
        int n = s.Length;
        for(int i = 0; i < n; i++)
        {
            if(dict.ContainsKey(s[i]))
            {
                dict[s[i]]++;
                //return dict[s[i]]++;
            }
            else
            {
                dict.Add(s[i],1);
            }
        }
        for(int i = 0; i < dict.Count; i++)
        {
            if(check.Contains(dict.ElementAt(i).Value) && dict.ElementAt(i).Value != 0)
            {
                dict[dict.ElementAt(i).Key]--;
                count++;
                i--;
            }
            else
            {
                check.Add(dict.ElementAt(i).Value);
            }
        }
        return count;
    }
}
