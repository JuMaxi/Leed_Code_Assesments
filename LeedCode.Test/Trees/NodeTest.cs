using FluentAssertions;

namespace LeedCode.Test.Trees
{
    public class NodeTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 3;

            head.Add(5);
            head.Add(8);
            head.Add(7);
            head.Add(6);
            head.Add(1);
            head.Add(2);
            head.Add(-5);
            head.Add(3);

            head.Right.Data.Should().Be(5);
            head.Right.Right.Data.Should().Be(8);
            head.Right.Right.Left.Data.Should().Be(7);
            head.Right.Right.Left.Left.Data.Should().Be(6);

            head.Left.Data.Should().Be(1);
            head.Left.Right.Data.Should().Be(2);
            head.Left.Right.Right.Data.Should().Be(3);
            head.Left.Left.Data.Should().Be(-5);


        }

        [Fact]
        public void Test_NumberExists()
        {
            Node head = new();
            head.Data = 3;

            head.Add(5);
            head.Add(8);
            head.Add(7);
            head.Add(6);
            head.Add(1);
            head.Add(2);
            head.Add(-5);
            head.Add(3);

            head.Contains(10).Should().BeFalse();
            head.Contains(5).Should().BeTrue();
            head.Contains(2).Should().BeTrue();
        }

        [Fact]
        public void Test_SumTree()
        {
            Node head = new();
            head.Data = 3;

            //head.Add(5);
            //head.Add(8);
            //head.Add(7);
            //head.Add(6);
            //head.Add(1);
            //head.Add(2);
            //head.Add(-5);
            //head.Add(3);
            head.Add(5);
            head.Add(8);
            head.Add(4);
            head.Add(1);

            int sum = head.Sum();

            sum.Should().Be(21);
        }

        [Fact]
        public void Test_SumTree2()
        {
            Node head = new();
            head.Data = 3;

            head.Add(5);
            head.Add(8);
            head.Add(7);
            head.Add(6);
            head.Add(1);
            head.Add(2);
            head.Add(-5);
            head.Add(3);

            int sum = head.Sum();

            sum.Should().Be(30);
        }

        [Fact]
        public void Test_SumTreeLeft()
        {
            Node head = new();
            head.Data = 3;
            head.Add(2);
            head.Add(1);

            int sum = head.Sum();
            sum.Should().Be(6);
        }

        [Fact]
        public void Test_Greater_Number()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(4);
            head.Add(1);
            head.Add(9);

            int greater = head.FindGreaterNumber();

            greater.Should().Be(9);
        }

        [Fact]
        public void Test_Depth1()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(4);
            head.Add(1);

            int depth = head.FindGreaterDepth();

            depth.Should().Be(2);

        }

        [Fact]
        public void Test_Depth2()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(7);
            head.Add(6);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);

            int deep = head.FindGreaterDepth();

            deep.Should().Be(4);

        }

        [Fact]
        public void Test_Depth3()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(13);
            head.Add(15);
            head.Add(9);
            head.Add(11);
            head.Add(7);
            head.Add(6);
            head.Add(5);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);
            head.Add(0);

            int deep = head.FindGreaterDepth();

            deep.Should().Be(5);

        }

        [Fact]
        public void Test_Balance1()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(4);
            head.Add(1);

            BalanceTree balance = head.FindIfTreeIsBalanced();

            balance.IsBalance.Should().BeTrue();

        }

        [Fact]
        public void Test_Balance2()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(7);
            head.Add(6);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);

            BalanceTree balance = head.FindIfTreeIsBalanced();

            balance.IsBalance.Should().BeFalse();

        }

        [Fact]
        public void Test_Balance3()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(13);
            head.Add(15);
            head.Add(9);
            head.Add(11);
            head.Add(7);
            head.Add(6);
            head.Add(5);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);
            head.Add(0);

            BalanceTree balance = head.FindIfTreeIsBalanced();

            balance.IsBalance.Should().BeFalse();
        }

        [Fact]
        public void Test_Balance4()
        {
            Node head = new();
            head.Data = 4;
            head.Add(1);
            head.Add(-5);
            head.Add(2);
            head.Add(3);
            head.Add(4);
            head.Add(5);
            head.Add(8);
            head.Add(7);

            BalanceTree balance = head.FindIfTreeIsBalanced();

            balance.IsBalance.Should().BeFalse();
        }

        [Fact]
        public void Test_NumberItems1()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(4);
            head.Add(1);

            int count = head.CountNumberItems();
            count.Should().Be(5);
        }


        [Fact]
        public void Test_NumberItems2()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(7);
            head.Add(6);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);

            int count = head.CountNumberItems();
            count.Should().Be(9);
        }

        [Fact]
        public void Test_NumberItems3()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(13);
            head.Add(15);
            head.Add(9);
            head.Add(11);
            head.Add(7);
            head.Add(6);
            head.Add(5);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);
            head.Add(0);

            int count = head.CountNumberItems();

            count.Should().Be(15);
        }

        [Fact]
        public void Test_NumberItems4()
        {
            Node head = new();
            head.Data = 4;
            head.Add(1);
            head.Add(-5);
            head.Add(2);
            head.Add(3);
            head.Add(4);
            head.Add(5);
            head.Add(8);
            head.Add(7);

            int count = head.CountNumberItems();

            count.Should().Be(9);
        }

        [Fact]
        public void Test_IsABinaryTree1()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(4);
            head.Add(1);

            BinarySearchTree binary = head.VerifyIfItIsABinarySearchTree();
            binary.IsBinary.Should().BeTrue();
        }

        [Fact]
        public void Test_IsABinaryTree2()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(7);
            head.Add(6);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);

            BinarySearchTree binary = head.VerifyIfItIsABinarySearchTree();
            binary.IsBinary.Should().BeTrue();
        }

        [Fact]
        public void Test_IsABinaryTree3()
        {
            Node head = new();
            head.Data = 3;
            head.Add(5);
            head.Add(8);
            head.Add(13);
            head.Add(15);
            head.Add(9);
            head.Add(11);
            head.Add(7);
            head.Add(6);
            head.Add(5);
            head.Add(1);
            head.Add(2);
            head.Add(3);
            head.Add(-5);
            head.Add(0);

            BinarySearchTree binary = head.VerifyIfItIsABinarySearchTree();
            binary.IsBinary.Should().BeTrue();
        }

        [Fact]
        public void Test_IsABinaryTree4()
        {
            Node head = new();
            head.Data = 4;
            head.Add(1);
            head.Add(-5);
            head.Add(2);
            head.Add(3);
            head.Add(4);
            head.Add(5);
            head.Add(8);
            head.Add(7);

            BinarySearchTree binary = head.VerifyIfItIsABinarySearchTree();
            binary.IsBinary.Should().BeTrue();
        }

        [Fact]
        public void Test_IsABinaryTree5()
        {
            Node head = new();
            head.Data = 3;

            Node right = new();
            right.Data = 1;
            head.Right = right; 

            Node left = new();
            left.Data = 2;
            head.Left = left;

            BinarySearchTree binary = head.VerifyIfItIsABinarySearchTree();
            binary.IsBinary.Should().BeFalse();
        }

        [Fact]
        public void Test_IsABinaryTree6()
        {
            Node head = new();
            head.Data = 3;

            Node right = new();
            right.Data = 5;
            head.Right = right;

            Node right2 = new();
            right2.Data = 8;
            right.Right = right2;

            Node right3 = new();
            right3.Data = 1;
            right2.Right = right3;

            BinarySearchTree binary = head.VerifyIfItIsABinarySearchTree();
            binary.IsBinary.Should().BeFalse();
        }


        [Fact]
        public void Test_IsABinaryTree7()
        {
            Node head = new();
            head.Data = 3;

            Node right = new();
            right.Data = 5;
            head.Right = right;

            Node right2 = new();
            right2.Data = 8;
            right.Right = right2;

            Node left = new();
            left.Data = 1;
            head.Left = left;

            Node left2 = new();
            left2.Data = 6;
            left.Left = left2;

            BinarySearchTree binary = head.VerifyIfItIsABinarySearchTree();
            binary.IsBinary.Should().BeFalse();
        }
    }
}
