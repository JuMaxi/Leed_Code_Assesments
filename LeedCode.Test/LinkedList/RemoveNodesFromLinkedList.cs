namespace LeedCode.Test.LinkedList;

public class RemoveNodesFromLinkedList
{
    public Node RemoveNodes(Node head)
    {
        if (head.Next == null)
        {
            return new Node { Data = head.Data };
        }
        else
        {
            var result = RemoveNodes(head.Next);

            if (head.Data >= result.Data)
            {
                Node tempNode = new();
                tempNode.Data = head.Data;
                tempNode.Next = result;

                result = tempNode;
            }
            return result;
        }
    }
}
