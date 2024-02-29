using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack;

public class CharStack
{
    public int MaxSize {  get; set; }
    public char[] StackArray { get; set; }
    public int Top { get; set; }

    public CharStack(int size)
    {
        this.MaxSize = size;
        this.StackArray = new char[size];
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
