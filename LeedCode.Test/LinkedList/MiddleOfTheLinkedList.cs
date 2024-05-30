namespace LeedCode.Test.LinkedList;

public class MiddleOfTheLinkedList
{
    public class PositionAndNodes
    {
        public int Position { get; set; }
        public Node Head { get; set; }
    }

    public Node MiddleNode(Node head)
    {
        return CountNodes(head, 1).Head;
    }

    private PositionAndNodes CountNodes(Node head, int Position)
    {
        if(head.Next is null)
        {
            Node node = new() { Data = head.Data };
            return new PositionAndNodes { Position = Position, Head = node};
        }
        else
        {
            var result = CountNodes(head.Next, Position + 1);

            if(Position > result.Position/2)
            {
                Node node = new() { Data = head.Data, Next = result.Head };
                result.Head = node;
            }
            return result;
        }
    }
}
