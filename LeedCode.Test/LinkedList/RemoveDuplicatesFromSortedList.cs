namespace LeedCode.Test.LinkedList;

public class RemoveDuplicatesFromSortedList
{
    public Node DeleteDuplicates(Node head)
    {
        Node newHead = head;

        while(head != null)
        {
            while(head.Next != null && head.Data == head.Next.Data)
            {
                head.Next = head.Next.Next;
            }

            head = head.Next;
        }

        return newHead;
    }
}
