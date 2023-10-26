using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsEX
{
    class LinkListGen<T> where T: IComparable
    {
        private NodeGen<T> head;

        public LinkListGen()
        {
            this.head = null;
        }
        public void AddToHead(T item)
        {
            NodeGen<T> newNodeGen = new NodeGen<T>(item);
            
            if (head == null)
            { head = newNodeGen; return; }

            newNodeGen.Next = head;
            head = newNodeGen;

        }
        public string s()
        {
            NodeGen<T> temp = head;
            string buffer = "";
            while (temp != null)
            {
                if (buffer.Length == 0) 
                { buffer = buffer + temp.Data + "-->"; }
                else
                { buffer = buffer + temp.Data + "-->"; }

                temp = temp.Next;
            }
            return buffer;
        }
        public int NumberOfItems()
        {
            NodeGen<T> temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
        public bool IsPresentItem(T item)
        {
            NodeGen<T> temp = head;
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) == 0)
                {  return true; }
                temp = temp.Next;
            }
            return false;
        }
        public void RemoveItem(T item)// remove occurrences of item from the list
        {
            NodeGen<T> oldList  = head;
            NodeGen<T> newList = null;
            
            while (oldList != null) 
            {
                if (item.CompareTo(oldList.Data) != 0)
                {
                    NodeGen<T> temp = new NodeGen<T> (oldList.Data);
                    if (newList == null)
                    { newList = temp; }
                    else
                    {
                        temp.Next = newList;
                        newList = temp;
                    }
                }
                oldList = oldList.Next;
            }
            head = newList;
        }

        public void AppendItem(T item)
        {
            NodeGen<T> temp = head;
            NodeGen<T> newNode = new NodeGen<T>(item);

            if (head == null)
            {
                head = newNode;
                return;
            }
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            head = temp;
        }

        public void InsertInOrder(T item)
        {
            NodeGen<T> newNode = new NodeGen<T>(item);

            if (head == null)
            {
                head = newNode;
                return;
            }
            if (item.CompareTo(head.Data) < 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            NodeGen<T> current = head;
            NodeGen<T> previous = null;
            while (current != null && item.CompareTo(current.Data) > 0)
            {
                previous = current;
                current = current.Next;
            }
            newNode.Next = current;
            previous.Next = newNode;
        }


    }
}
