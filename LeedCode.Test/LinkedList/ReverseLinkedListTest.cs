using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class ReverseLinkedListTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 1;
            for (int i = 2; i <= 5; i++)
            {
                head.Add(i);
            }

            ReverseLinkedList reverse = new();
            Node answer = reverse.ReverseList(head);

            Node expected = new();
            expected.Data = 5;
            for (int i = 4; i >= 1; i--)
            {
                expected.Add(i);
            }

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 1;
            for (int i = 2; i <= 2; i++)
            {
                head.Add(i);
            }

            ReverseLinkedList reverse = new();
            Node answer = reverse.ReverseList(head);

            Node expected = new();
            expected.Data = 2;
            for (int i = 1; i >= 1; i--)
            {
                expected.Add(i);
            }

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
