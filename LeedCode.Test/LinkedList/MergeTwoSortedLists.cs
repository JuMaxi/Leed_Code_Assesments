namespace LeedCode.Test.LinkedList;

public class MergeTwoSortedLists
{
    public Node MergeTwoLists(Node list1, Node list2)
    {
        Node mergedList = new();

        //Save new sorted node while the two linked lists are not null
        while (list1 is not null && list2 is not null)
        {
            if (list1.Data < list2.Data)
            {
                mergedList = CreateNewNode(list1, mergedList);
                list1 = list1.Next;
            }
            else
            {
                if (list1.Data > list2.Data)
                {
                    mergedList = CreateNewNode(list2, mergedList);
                    list2 = list2.Next;
                }
                else
                {
                    mergedList = CreateNewNode(list1, mergedList);
                    mergedList = CreateNewNode(list2, mergedList);
                    list1 = list1.Next;
                    list2 = list2.Next;
                }
            }
        }

        //Verify if some of the lists is not null, if so, create new nodes in the sorted/merged linked list.
        mergedList = VerifyIfLinkedListIsNotNull(list1, mergedList);
        mergedList = VerifyIfLinkedListIsNotNull(list2, mergedList);

        return mergedList.Next;
    }

    private Node CreateNewNode(Node list, Node mergedList)
    {
        //Create new node as last
        Node current = mergedList;

        while(current.Next is not null)
        {
            current = current.Next;
        }
        
        Node node = new() { Data = list.Data };
        current.Next = node;

        return mergedList;
    }

    private Node VerifyIfLinkedListIsNotNull(Node list, Node mergedList)
    {
        //If the linked is not null, should save the data in the merged linked list.
        if(list is not null)
        {
            while(list is not null)
            {
                mergedList = CreateNewNode(list, mergedList);
                list = list.Next;
            }
        }
        return mergedList;
    }
}
