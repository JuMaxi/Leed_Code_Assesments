using FluentAssertions;

namespace LeedCode.Test.Trees
{
    public class InsertingNumbersInOrderTest
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

            balance.IsBalance.Should().BeTrue();
        }
    }
}
