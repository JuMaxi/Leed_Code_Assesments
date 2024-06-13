namespace LeedCode.Test.LinkedList;

public class PalindromeLinkedList
{
    public bool IsPalindrome(Node head)
    {
        Stack<int> stack = new();
        Node temp = head;

        while(head != null)
        {
            stack.Push(head.Data);
            head = head.Next;
        }

        while(temp != null)
        {
            if(temp.Data != stack.Pop())
            {
                return false;
            }
            //stack.Pop();
            temp = temp.Next;
        }

        return true;
    }
}
