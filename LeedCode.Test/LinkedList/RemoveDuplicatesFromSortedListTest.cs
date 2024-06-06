using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class RemoveDuplicatesFromSortedListTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 1;
            head.Add(1);
            head.Add(2);

            RemoveDuplicatesFromSortedList remove = new();
            Node answer = remove.DeleteDuplicates(head);

            Node expected = new();
            expected.Data = 1;
            expected.Add(2);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 1;
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(3);

            RemoveDuplicatesFromSortedList remove = new();
            Node answer = remove.DeleteDuplicates(head);

            Node expected = new();
            expected.Data = 1;
            expected.Add(2);
            expected.Add(3);

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
