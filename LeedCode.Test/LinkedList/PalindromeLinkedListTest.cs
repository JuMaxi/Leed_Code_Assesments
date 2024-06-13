namespace LeedCode.Test.LinkedList
{
    public class PalindromeLinkedListTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 1;
            head.Add(2);
            head.Add(2);
            head.Add(1);

            PalindromeLinkedList palindrome = new();
            bool answer = palindrome.IsPalindrome(head);

            Assert.True(answer);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 1;
            head.Add(2);

            PalindromeLinkedList palindrome = new();
            bool answer = palindrome.IsPalindrome(head);

            Assert.False(answer);
        }

        [Fact]
        public void Test03()
        {
            Node head = new();
            head.Data = 1;
            head.Add(0);
            head.Add(1);

            PalindromeLinkedList palindrome = new();
            bool answer = palindrome.IsPalindrome(head);

            Assert.True(answer);
        }
    }
}
