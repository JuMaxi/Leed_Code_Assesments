using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System.Reflection.Metadata.Ecma335;

namespace LeedCode.Test.Trees
{
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
            if(Right != null)
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
            int depth = 0;
            int end;

            if (Right != null)
            {
                depth = 1 + Right.FindGreaterDepth();

            }

            end = depth;

            if (Left != null)
            {
                depth = 1 + Left.FindGreaterDepth();
            }

            return Math.Max(depth, end);
        }
    }
}
