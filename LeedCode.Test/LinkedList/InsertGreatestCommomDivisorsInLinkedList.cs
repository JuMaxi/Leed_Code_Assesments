namespace LeedCode.Test.LinkedList;

public class InsertGreatestCommomDivisorsInLinkedList
{
    public Node InsertGreatestCommonDivisors(Node head)
    {
        Node newHead = head;
        while(head.Next != null)
        {
            int answer = 1;

            int smaller = Math.Min(head.Data, head.Next.Data);
            int currentData = head.Data;
            int nextData = head.Next.Data;

            for(int i = 2; i <= smaller; i++)
            {
                if(currentData % i == 0 && nextData % i == 0)
                {
                    answer *= i;
                    currentData = currentData / i;
                    nextData = nextData / i;

                    if(currentData == 1 || nextData == 1)
                    {
                        break;
                    }

                    i--;
                }
            }
            Node node = new();
            node.Data = answer;
            node.Next = head.Next;
            head.Next = node;

            head = head.Next.Next;
        }
        return newHead;
    }
}
