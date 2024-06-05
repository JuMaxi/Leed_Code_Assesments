using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class RemoveLinkedListElementsTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 1;
            head.Add(2);
            head.Add(6);
            head.Add(3);
            head.Add(4);
            head.Add(5);
            head.Add(6);

            RemoveLinkedListElements remove = new();
            Node answer = remove.RemoveElements(head, 6);

            Node expected = new();
            expected.Data = 1;
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test04()
        {
            Node head = new();
            head.Data = 1;
            head.Add(2);
            head.Add(6);
            head.Add(6);
            head.Add(3);
            head.Add(4);
            head.Add(5);
            head.Add(6);

            RemoveLinkedListElements remove = new();
            Node answer = remove.RemoveElements(head, 6);

            Node expected = new();
            expected.Data = 1;
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);

            answer.Should().BeEquivalentTo(expected);
        }


        [Fact]
        public void Test02()
        {
            Node head = null;

            RemoveLinkedListElements remove = new();
            Node answer = remove.RemoveElements(head, 1);

            Node expected = null;

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test03()
        {
            Node head = new();
            head.Data = 7;
            head.Add(7);
            head.Add(7);
            head.Add(7);

            RemoveLinkedListElements remove = new();
            Node answer = remove.RemoveElements(head, 7);

            Node expected = null;

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
