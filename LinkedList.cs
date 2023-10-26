using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsEX
{
    class LinkedList
    {
        private Node head=null;
        
        public LinkedList() 
        {
            this.head = null;
        }
        public void AddToHead(int item)
        {
            Node newNode = new Node(item);
            if (head == null ) 
            {
                head = newNode;
                return;
            }
            newNode.Next = head;
            head = newNode;
        }

        public string DisplayItems()
        {
            Node temp = head;
            string buffer = "";
            while (temp != null)
            {
                if (buffer.Length == 0) 
                {
                    buffer = buffer + temp.Data;
                }
                else 
                {
                    buffer = buffer + "->" + temp.Data;
                }
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;

        }

        public bool ItemIsPresent (int item) 
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data == item) { return true; }
                temp = temp.Next;
            }
            return false;
        }
    }
}
