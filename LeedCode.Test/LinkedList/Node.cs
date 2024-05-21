using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public void Add(int data)
        {
            if(Next == null)
            {
                Node node = new Node();
                node.Data = data;
                Next = node;
            }
            else
            {
                Next.Add(data);
            }
        }
    }


}
