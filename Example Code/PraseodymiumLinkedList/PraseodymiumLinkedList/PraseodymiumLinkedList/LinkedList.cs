using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraseodymiumLinkedList
{
    public class LinkedList
    {
        Node start;
        Node tail;

        public void InsertAtEnd(int data)
        {
            Node node = new Node(data); //10
            if(start == null)
            {
                start = node;
                return;
            }
            
            Node temp = start; //7
            while (temp.link != null)
            {
                temp = temp.link;
            }
            temp.link = node;
        }
    }
}
