namespace LeedCode.Test.Stack;

public class RemoveOutermostParentheses
{
    public string RemoveOuterParentheses(string s)
    {
        Stack<char> stack = new Stack<char>();
        string answer = "";

        int index = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(s[i]);
                
                if(stack.Count == 1)
                {
                    index = (i + 1);
                }
            }
            else
            {
                stack.Pop();

                if(stack.Count == 0)
                {
                    answer = SaveStringParentheses(s, answer, index, i);
                }
            }
        }
        return answer;
    }

    private string SaveStringParentheses(string input, string answer, int firstIndex, int lastIndex)
    {
        answer += input.Substring(firstIndex, lastIndex - firstIndex);

        return answer;
    }
    
}
