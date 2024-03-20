using LeedCode.Test.ArraysAndHashing;
using LeedCode.Test.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack;

public class StackWithLinkedList
{
    public LinkedListEx LinkedList {  get; set; }

    public StackWithLinkedList()
    {
        this.LinkedList = new();
    }

    public void Push(int val)
    {
        LinkedList.InsertFirst(val);
    }

    public int Pop()
    {
        return LinkedList.DeleteFirst().Data;
    }

    
    
}
