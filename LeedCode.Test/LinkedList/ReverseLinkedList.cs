namespace LeedCode.Test.LinkedList;

public class ReverseLinkedList
{
    public class ReturnNode
    {
        public Node head { get; set; }
        public Node current { get; set; }
    }
    public Node ReverseList(Node head)
    {
        return GetNodes(head).head;

    }
    private ReturnNode GetNodes(Node head)
    {
        if (head.Next is null)
        {
            Node node = new() { Data = head.Data };

            return new ReturnNode { head = node, current = node };
        }
        else
        {
            var result = GetNodes(head.Next);

            Node tempNode = new() { Data = head.Data };
            result.current.Next = tempNode;
            result.current = tempNode;

            return result;
        }
    }

}
