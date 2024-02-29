namespace LeedCode.Test.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length < 2)
        {
            return false;
        }

        string allParentheses = "(){}[]";
        CharStack stack = new(s.Length);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else
            {
                char c = allParentheses[allParentheses.IndexOf(s[i]) - 1];
                if (!stack.IsEmpty() && stack.Peek() == c)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

        }

        if (!stack.IsEmpty())
        {
            return false;
        }

        return true;
    }
}
