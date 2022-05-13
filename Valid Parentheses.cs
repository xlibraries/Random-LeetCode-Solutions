//Question Link:-https://leetcode.com/explore/learn/card/queue-stack/230/usage-stack/1361/
public class Solution 
{
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if(stack.Count > 0 && c == ')' && stack.Peek() == '(')
                    stack.Pop();
            else if(stack.Count > 0 && c == '}' && stack.Peek() == '{')
                    stack.Pop();
            else if(stack.Count > 0 && c == ']' && stack.Peek() == '[')
                    stack.Pop();
            else
                stack.Push(c);
        }
        return stack.Count == 0;
    }
}
