using FluentAssertions;

namespace LeedCode.Test.LinkedList
{
    public class MergeTwoSortedListsTest
    {
        [Fact]
        public void Test01()
        {
            Node list1 = new Node();
            list1.Data = 1;
            list1.Add(2);
            list1.Add(4);

            Node list2 = new Node();
            list2.Data = 1;
            list2.Add(3);
            list2.Add(4);

            MergeTwoSortedLists merge = new();
            Node answer = merge.MergeTwoLists(list1, list2);

            Node expected = new();
            expected.Data = 1;
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(4);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            Node list1 = new Node();
            list1.Data = 1;
            list1.Add(2);
            list1.Add(4);

            Node list2 = new Node();
            list2.Data = 3;
            list2.Add(5);
            list2.Add(6);
            list2.Add(7);
        }

        [Fact]
        public void Test03()
        {
            Node list1 = null;
            Node list2 = null;

            MergeTwoSortedLists merge = new();
            Node answer = merge.MergeTwoLists(list1 , list2);

            Node expected = null;

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test04()
        {
            Node list1 = null;
            Node list2 = new() { Data = 0 };

            MergeTwoSortedLists merge = new();
            Node answer = merge.MergeTwoLists(list1, list2);

            Node expected = new() { Data = 0};

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
