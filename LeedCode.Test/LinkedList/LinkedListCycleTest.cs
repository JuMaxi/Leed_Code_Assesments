using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class LinkedListCycleTest
    {
        [Fact]
        public void Test01()
        {
            Node node1 = new();
            Node node2 = new();
            Node node3 = new();
            Node node4 = new();

            node1.Data = 3;
            node2.Data = 2;
            node3.Data = 0;
            node4.Data = -4;

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node2;

            LinkedListCycle cycle = new();
            bool answer = cycle.HasCycle(node1);

            answer.Should().BeTrue();
        }

        [Fact]
        public void Test02()
        {
            Node node1 = new();
            Node node2 = new();
            node1.Data = 1;
            node2.Data = 2;
            node1.Next = node2;
            node2.Next = node1;

            LinkedListCycle cycle = new();
            bool answer = cycle.HasCycle(node1);

            answer.Should().BeTrue();
        }

        [Fact]
        public void Test03()
        {
            Node node1 = new();
            node1.Data = 1;

            LinkedListCycle cycle = new();
            bool answer = cycle.HasCycle(node1);

            answer.Should().BeFalse();

        }
    }
}
