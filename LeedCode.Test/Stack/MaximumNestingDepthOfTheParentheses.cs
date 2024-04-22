namespace LeedCode.Test.Stack;

public class MaximumNestingDepthOfTheParentheses
{
    public int MaxDepth(string s)
    {
        Stack<char> stack = new();
        int answer = 0;
        int temp = 0;

        foreach(char c in s)
        {
            if (c == '(')
            {
                stack.Push(c);
                temp++;
            }
            else
            {
                if (c == ')')
                {
                    stack.Pop();

                    answer = Math.Max(temp, answer);

                    temp = stack.Count;
                }
            }
        }

        return answer;
    }
}
