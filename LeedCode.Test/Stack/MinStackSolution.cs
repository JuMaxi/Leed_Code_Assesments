using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack
{
    public class MinStackSolution
    {
        public string[] TakeValuesStack(int[] ints, string[] commands)
        {
            MinStack stack = new();
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
