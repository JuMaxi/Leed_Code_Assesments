namespace LeedCode.Test.LinkedList;

public class ReverseLinkedList
{
    public Node ReverseList(Node head)
    {
        if (head.Next == null)
        {
            return new Node { Data = head.Data };
        }
        else
        {
            var newNode = ReverseList(head.Next);

            var current = newNode;

            while(current.Next is not null)
            {
                current = current.Next;
            }

            Node tempNode = new Node { Data = head.Data };
            current.Next = tempNode;

            return newNode;
        }
    }
}
