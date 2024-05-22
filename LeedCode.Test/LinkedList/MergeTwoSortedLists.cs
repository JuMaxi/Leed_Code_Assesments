using FluentAssertions.Equivalency;
using System.ComponentModel.Design;

namespace LeedCode.Test.LinkedList
{
    public class MergeTwoSortedLists
    {
        public Node? mergedList;

        public Node MergeTwoLists(Node list1, Node list2)
        {
            if (VerifyNextIsNotNullAndDataIsLessOrEqual(list1, list2))
            {
                mergedList = CallFunctions(list1, list2);
            }
            else
            {
                if (VerifyNextIsNotNullAndDataIsLessOrEqual(list2, list1))
                {
                    mergedList = CallFunctions(list2, list1);
                }
            }

            mergedList = SaveMergedListIfNextIsNull(list1, list2, mergedList);

            return mergedList;
        }

        private Node SaveMergedListIfNextIsNull(Node list1, Node list2, Node mergedList)
        {
            if (VerifyNextIsNullAndDataIsLessOrEqual(list1, list2))
            {
                mergedList = SaveMergedList(list1, mergedList);
            }
            if (VerifyNextIsNullAndDataIsLessOrEqual(list2, list1))
            {
                mergedList = SaveMergedList(list2, mergedList);
            }

            return mergedList;
        }
        private bool VerifyNextIsNullAndDataIsLessOrEqual(Node list1, Node list2)
        {
            if (list1.Next is null && list1.Data <= list2.Data)
            {
                return true;
            }
            return false;
        }

        private Node SaveMergedList(Node list, Node MergedList)
        {
            Node newNode = new();
            newNode.Data = list.Data;
            newNode.Next = mergedList;
            mergedList = newNode;

            return mergedList;
        }

        private bool VerifyNextIsNotNullAndDataIsLessOrEqual(Node list1, Node list2)
        {
            if (list1.Next is not null && list1.Data <= list2.Data)
            {
                return true;
            }
            return false;
        }

        private Node CallFunctions(Node list1, Node list2)
        {
            MergeTwoLists(list1.Next, list2);
            mergedList = SaveMergedList(list1, mergedList);

            return mergedList;
        }



    }
}
