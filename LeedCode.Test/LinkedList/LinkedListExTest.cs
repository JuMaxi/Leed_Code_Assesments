namespace LeedCode.Test.LinkedList
{
    public class LinkedListExTest
    {
        [Fact]
        public void IterateLinkedList()
        {
            LinkedListEx linkedList = new();

            linkedList.InsertFirst(1);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(4);

            linkedList.DeleteFirst();
            linkedList.DeleteFirst();

            linkedList.InsertLast(546);
            linkedList.InsertLast(3434);

            linkedList.DisplayList();

        }
    }
}
