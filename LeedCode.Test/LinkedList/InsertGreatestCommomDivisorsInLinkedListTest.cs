using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class InsertGreatestCommomDivisorsInLinkedListTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 18;
            head.Add(6);
            head.Add(10);
            head.Add(3);

            InsertGreatestCommomDivisorsInLinkedList insert = new();
            Node answer = insert.InsertGreatestCommonDivisors(head);

            Node expected = new();
            expected.Data = 18;
            expected.Add(6);
            expected.Add(6);
            expected.Add(2);
            expected.Add(10);
            expected.Add(1);
            expected.Add(3);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 7;

            InsertGreatestCommomDivisorsInLinkedList insert = new();
            Node answer = insert.InsertGreatestCommonDivisors(head);

            Node expected = new();
            expected.Data = 7;

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
