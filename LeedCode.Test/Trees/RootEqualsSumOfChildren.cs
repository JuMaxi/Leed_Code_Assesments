namespace LeedCode.Test.Trees;

public class RootEqualsSumOfChildren
{
    public bool CheckTree(Node head)
    {
        if (SumChild(head) == 0)
        {
            return true;
        }
        return false;
    }
    private int SumChild(Node head)
    {
        int sum = head.Data;

        if (head.Right != null)
        {
            sum -= SumChild(head.Right);
        }
        if (head.Left != null)
        {
            sum -= SumChild(head.Left);
        }

        return sum;
    }
}
