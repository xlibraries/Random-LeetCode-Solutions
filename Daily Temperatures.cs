//Question Link:- https://leetcode.com/problems/daily-temperatures/
public class Solution 
{
    public int[] DailyTemperatures(int[] temperatures) 
    {
          int n = temperatures.Length;
        int hottest = 0;
        int[] answer = new int[n];
        
        for (int currDay = n - 1; currDay >= 0; currDay--) {
            int currentTemp = temperatures[currDay];
            if (currentTemp >= hottest) {
                hottest = currentTemp;
                continue;
            }
            
            int days = 1;
            while (temperatures[currDay + days] <= currentTemp) {
                // Use information from answer to search for the next warmer day
                days += answer[currDay + days];
            }
            answer[currDay] = days;
        }
        
        return answer;
    }
}
