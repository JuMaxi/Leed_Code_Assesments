using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class MiddleOfTheLinkedListTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 1;
            head.Add(2);
            head.Add(3);
            head.Add(4);
            head.Add(5);

            MiddleOfTheLinkedList middle = new();
            Node answer = middle.MiddleNode(head);

            Node expected = new();
            expected.Data = 3;
            expected.Add(4);
            expected.Add(5);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 1;
            head.Add(2);
            head.Add(3);
            head.Add(4);
            head.Add(5);
            head.Add(6);

            MiddleOfTheLinkedList middle = new();
            Node answer = middle.MiddleNode(head);

            Node expected = new();
            expected.Data = 4;
            expected.Add(5);
            expected.Add(6);

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
