namespace LeedCode.Test.Trees;

public class SearchInABinaryTree
{
    public Node SearchBST(Node head, int val)
    {
        if (val == head.Data)
        {
            return head;
        }

        if (val > head.Data)
        {
            if (head.Right != null)
            {
                return SearchBST(head.Right, val);
            }
        }

        if (val < head.Data)
        {
            if (head.Left != null)
            {
                return SearchBST(head.Left, val);
            }
        }

        return null;
    }
}
