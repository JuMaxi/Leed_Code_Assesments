using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack;

public class CharStack
{
    public char[] StackArray { get; set; }
    public int Top { get; set; }

    public CharStack()
    {
        this.StackArray = new char[10000];
        this.Top = -1;
    }

    public void Push(char item)
    {
        Top++;
        StackArray[Top] = item;
    }

    public void Pop()
    {
        Top--;
    }

    public char Peek()
    {
        return StackArray[Top];
    }

    public bool IsEmpty()
    {
        return Top == -1;
    }
}
