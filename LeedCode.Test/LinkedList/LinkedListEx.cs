using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.LinkedList
{
    public class LinkedListEx
    {
        public Node First {  get; set; }

        public void InsertFirst(int data)
        {
            Node newNode = new();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Node current = First;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            if(First is not null)
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                Node newNode = new();
                newNode.Data = data;
                current.Next = newNode;
            }
            else
            {
                Node newNode = new();
                newNode.Data = data;
                First = newNode;
            }
            
        }
    }
}
