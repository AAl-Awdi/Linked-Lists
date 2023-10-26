using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsEX
{
    class NodeGen<T>
    {
        private T data;
        private NodeGen<T> next;

        public NodeGen(T item)
        {
            this.data = item;
            next = null;
        } 

        public NodeGen<T> Next
        {
            set { this.next = value; }
            get { return this.next; }
        }

        public T Data
        {
            set { this.data = value; }
            get { return this.data; }
        }
    }
}
