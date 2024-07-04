using FluentAssertions;

namespace LeedCode.Test.Trees
{
    public class RootEqualsSumOfChildrenTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 10;
            
            Node right = new();
            right.Data = 6;
            head.Right = right;

            Node left = new();
            left.Data = 4;
            head.Left = left;

            RootEqualsSumOfChildren root = new();
            root.CheckTree(head).Should().BeTrue();
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 5;

            Node right = new();
            right.Data = 1;
            head.Right = right;

            Node left = new();
            left.Data = 3;
            head.Left = left;

            RootEqualsSumOfChildren root = new();
            root.CheckTree(head).Should().BeFalse();
        }
    }
}
