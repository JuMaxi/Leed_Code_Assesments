using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System.Reflection.Metadata.Ecma335;

namespace LeedCode.Test.Trees
{
    public class BalanceTree
    {
        public bool IsBalance { get; set; }
        public int Right { get; set; }
        public int Left { get; set; }
    }
    public class BinarySearchTree
    {
        public bool IsBinary {  get; set; }
        public int Data { get; set; }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node? Right { get; set; }
        public Node? Left { get; set; }

        public void Add(int number)
        {
            if (number > Data)
            {
                if (Right == null)
                {
                    Node node = new();
                    node.Data = number;
                    Right = node;
                }
                else
                {
                    Right.Add(number);
                }
            }
            else
            {
                if (Left == null)
                {
                    Node node = new();
                    node.Data = number;
                    Left = node;
                }
                else
                {
                    Left.Add(number);
                }
            }
        }

        public bool Contains(int number)
        {
            if (Data == number)
            {
                return true;
            }
            else
            {
                if (Data < number)
                {
                    if (Right == null)
                    {
                        return false;
                    }
                    return Right.Contains(number);
                }
                else
                {
                    if (Left == null)
                    {
                        return false;
                    }
                    return Left.Contains(number);
                }

            }
        }

        public int Sum()
        {
            int sum = Data;

            if (Right != null)
            {
                sum += Right.Sum();
            }

            if (Left != null)
            {
                sum += Left.Sum();
            }

            return sum;
        }

        public int FindGreaterNumber()
        {
            if (Right != null)
            {
                int greater = Right.FindGreaterNumber();

                return Math.Max(greater, Data);
            }
            else
            {
                return Data;
            }
        }

        public int FindGreaterDepth()
        {
            int right = 0;
            int left = 0;

            if (Right != null)
            {
                right = 1 + Right.FindGreaterDepth();

            }

            if (Left != null)
            {
                left = 1 + Left.FindGreaterDepth();
            }

            return Math.Max(right, left);
        }

        public BalanceTree FindIfTreeIsBalanced()
        {
            BalanceTree balance = new();
            balance.IsBalance = true;

            if (Right != null)
            {
                var resultRight = Right.FindIfTreeIsBalanced();
                balance.Right = resultRight.Right + 1;
                balance.IsBalance = resultRight.IsBalance;
            }

            if (balance.IsBalance == false)
            {
                return balance;
            }

            if (Left != null)
            {
                var resultLeft = Left.FindIfTreeIsBalanced();
                balance.Left = resultLeft.Left + 1;
                balance.IsBalance = resultLeft.IsBalance;
            }

            if (Math.Abs(balance.Right - balance.Left) > 1)
            {
                balance.IsBalance = false;
            }

            return balance;
        }

        public int CountNumberItems()
        {
            int count = 1;

            if (Right != null)
            {
                count += Right.CountNumberItems();
            }

            if (Left != null)
            {
                count += Left.CountNumberItems();
            }

            return count;
        }

        public BinarySearchTree VerifyIfItIsABinarySearchTree()
        {
            BinarySearchTree binary = new();
            binary.Data = Data;
            binary.IsBinary = true;

            if (Right != null)
            {
                binary = Right.VerifyIfItIsABinarySearchTree();

                if(binary.Data < Data)
                {
                    binary.IsBinary = false;
                    return binary;
                }

            }

            if (Left != null)
            {
                binary = Left.VerifyIfItIsABinarySearchTree();

                if(binary.Data > Data)
                {
                    binary.IsBinary = false;
                    return binary;
                }
            }
            return binary;
        }

    }
}
