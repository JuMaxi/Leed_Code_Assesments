namespace LeedCode.Test.LinkedList;

public class PalindromeLinkedList
{
    public class ReturnNodes
    {
        public bool Palindrome { get; set; }
        public Node Node { get; set; }
    }
    public bool IsPalindrome(Node head)
    {
        Node temp = head;
        return CreateNewNode(head, temp).Palindrome;
    }

    private ReturnNodes CreateNewNode(Node head, Node temp)
    {
        if (head is null)
        {
            return new ReturnNodes { Palindrome = true, Node = temp};
        }
        else
        {
            var answer = CreateNewNode(head.Next, temp);

            if(answer.Palindrome is false) 
            { 
                return answer;
            }

            if(answer.Node.Data != head.Data)
            {
                answer.Palindrome = false;
                return answer;
            }

            answer.Node = answer.Node.Next;

            return answer;
        }
    }
}
