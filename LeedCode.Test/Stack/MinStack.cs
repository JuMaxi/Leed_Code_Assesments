using LeedCode.Test.ArraysAndHashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack;

public class MinStack
{
    public int[] StackArray { get; set; }
    public int Top { get; set; }

    public MinStack()
    {
        this.StackArray = new int[10];
        this.Top = -1;
    }

    public void Push(int val)
    {
        Top++;
        StackArray[Top] = val;
    }

    public void Pop()
    {
        Top--;
    }

    public int GetTop()
    {
        return StackArray[Top];
    }

    public int GetMin()
    {
        int temp = int.MaxValue;
        for(int i = 0; i <= Top; i++)
        {
            if (StackArray[i] < temp)
            {
                temp = StackArray[i];
            }
        }
        return temp;
    }
}
