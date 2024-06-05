namespace LeedCode.Test.LinkedList;

public class RemoveLinkedListElements
{
    public Node RemoveElements(Node head, int val)
    {
        Node node = head;
        while (head != null)
        {
            while (head.Next != null && head.Next.Data == val)
            {
                head.Next = head.Next.Next;
            }
            head = head.Next;
        }

        if(node != null && node.Data == val)
        {
            node = node.Next;
        }
        return node;
    }
}
