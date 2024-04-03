using LeedCode.Test.ArraysAndHashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack;

public class Stack
{
    public int[] StackArray { get; set; }
    public int Top { get; set; }
    public int MaxSize { get; set; }

    public Stack(int size)
    {   
        this.MaxSize = size;
        this.StackArray = new int[size];
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

    //Get Top
    public int Peek()
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
