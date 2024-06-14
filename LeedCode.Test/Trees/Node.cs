namespace LeedCode.Test.Trees
{
    public class Node
    {
        public int Data {  get; set; }
        public Node? Right { get; set; }
        public Node? Left { get; set; }

        public void Add(int number)
        { 
            if(number > Data)
            {
                if(Right == null)
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
                if(Left == null)
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
    }
}
