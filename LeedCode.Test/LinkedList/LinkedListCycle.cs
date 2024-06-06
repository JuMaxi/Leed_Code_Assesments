namespace LeedCode.Test.LinkedList;

public class LinkedListCycle
{
    public bool HasCycle(Node head)
    {
        Dictionary<Node, int> dict = new();
        while(head != null)
        {
            if (!dict.ContainsKey(head))
            {
                dict.Add(head, 1);
                head = head.Next;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
