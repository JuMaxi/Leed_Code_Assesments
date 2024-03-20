namespace LeedCode.Test.Stack
{
    public class MinStack
    {
        public string[] TakeValuesStack(int[] ints, string[] commands)
        {
            Stack stack = new(ints.Length);
            string[] answer = new string[ints.Length]; 


            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "push")
                {
                    stack.Push(ints[i]);
                    answer[i] = null;
                }
                else
                {
                    if (commands[i] == "getMin")
                    {
                        answer[i] = stack.GetMin().ToString();
                    }
                    else
                    {
                        if (commands[i] == "pop")
                        {
                            answer[i] = null;
                            stack.Pop();
                        }
                        else
                        {
                            if (commands[i] == "top")
                            {
                                answer[i] = stack.GetTop().ToString();
                            }
                        }
                    }
                }

            }

            return answer;
        }
    }
}
