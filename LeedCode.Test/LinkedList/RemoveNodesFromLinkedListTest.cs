using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class RemoveNodesFromLinkedListTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 5;
            head.Add(2);
            head.Add(13);
            head.Add(3);
            head.Add(8);

            RemoveNodesFromLinkedList remove = new();
            Node answer = remove.RemoveNodes(head);

            Node expected = new();
            expected.Data = 13;
            expected.Add(8);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 1;
            head.Add(1);
            head.Add(1);
            head.Add(1);

            RemoveNodesFromLinkedList remove = new();
            Node answer = remove.RemoveNodes(head);

            Node expected = new();
            expected.Data = 1;
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
