using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class LinkedList
    {
        private Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
                Head = newNode;
            else
            {
                Node current = Head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newNode;
            }
        }

        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int Length()
        {
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                length++;
            }
            return length;
        }

    }
}