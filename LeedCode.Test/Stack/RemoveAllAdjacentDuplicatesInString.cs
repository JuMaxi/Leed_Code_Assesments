using System.Text;

namespace LeedCode.Test.Stack
{
    public class RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string s)
        {
            Stack<char> stack = new();

            for(int i = 0; i < s.Length; i++)
            {
                if(stack.Count > 0 && stack.Peek() == s[i])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            StringBuilder answer = new();

            for(int i = stack.Count; i >= 1; i--)
            {
                answer.Append(stack.Pop());
            }

            return new string (answer.ToString().Reverse().ToArray());
        }
    }
}
