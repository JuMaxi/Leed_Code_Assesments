namespace LeedCode.Test.Stack
{
    public class EvaluateReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            Stack stack = new(tokens.Length);

            foreach (string token in tokens)
            {
                if (char.IsDigit(token[0]))
                {
                    stack.Push(Convert.ToInt32(token));
                }
                else
                {
                    int initialTop = 1;
                    for(int p = 0; p < 2; p++)
                    {
                        int top = stack.GetTop();
                        stack.Pop();
                        if(p == 1)
                        {
                            if (token == "+")
                            {
                                top += initialTop;
                            }
                            else
                            {
                                if(token == "-")
                                {
                                    top -= initialTop;
                                }
                                else
                                {
                                    if(token == "*")
                                    {
                                        top *= initialTop;
                                    }
                                    else
                                    {
                                        top /= initialTop;
                                    }
                                }
                            }
                            stack.Push(top);
                            break;
                        }
                        initialTop = top;
                    }
                }
            }
            return stack.GetTop();
        }
    }
}
