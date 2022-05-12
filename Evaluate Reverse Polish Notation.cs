//Question Link:-https://leetcode.com/explore/learn/card/queue-stack/230/usage-stack/1394/
public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        if(tokens.Length == 1)
        {
            return Convert.ToInt32(tokens[0]);
        }
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < tokens.Length; i++)
        {
            if(tokens[i] == "+")
            {
                int temp = 0;
                int a = stack.Pop();
                int b = stack.Pop();
                temp = b + a;
                stack.Push(temp);
            }
            else if(tokens[i] == "-")
            {
                int temp = 0;
                int a = stack.Pop();
                int b = stack.Pop();
                temp = b - a;
                stack.Push(temp);
            }
            else if(tokens[i] == "*")
            {
                int temp = 0;
                int a = stack.Pop();
                int b = stack.Pop();
                temp = b * a;
                stack.Push(temp);
            }
            else if(tokens[i] == "/")
            {
                int temp = 0;
                int a = stack.Pop();
                int b = stack.Pop();
                temp = b / a;
                stack.Push(temp);
            }
            else
            {
                stack.Push(Convert.ToInt32(tokens[i]));
            }
        }
        return  stack.Pop();
    }
}
