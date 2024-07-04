using FluentAssertions;

namespace LeedCode.Test.Trees
{
    public class SearchInABinaryTreeTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 4;
            head.Add(7);
            head.Add(2);
            head.Add(1);
            head.Add(3);

            Node answer = new();
            answer.Data = 2;
            answer.Add(1);
            answer.Add(3);

            SearchInABinaryTree tree = new();
            tree.SearchBST(head, 2).Should().BeEquivalentTo(answer);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 4;
            head.Add(7);
            head.Add(2);
            head.Add(1);
            head.Add(3);

            Node answer = null;

            SearchInABinaryTree tree = new();
            tree.SearchBST(head, 5).Should().BeEquivalentTo(answer);
        }
    }
}
