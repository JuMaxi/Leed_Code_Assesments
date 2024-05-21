namespace LeedCode.Test.LinkedList
{
    public class ReverseLinkedList
    {
        public Node? Node;
        public Node ReverseList(Node head)
        {
            Node newNode = new();
            newNode.Data = head.Data;
            newNode.Next = Node;
            Node = newNode;

            if (head.Next is not null)
            {
                ReverseList(head.Next);
            }

            return Node;
        }
    }
}
