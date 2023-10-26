using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList testList = new LinkedList();
            LinkListGen<int> testListGen = new LinkListGen<int>();

            Random rdm = new Random();
            int randomNumb = rdm.Next(0,10);

            testList.AddToHead(1);
            testList.AddToHead(2);
            testList.AddToHead(54);
            testList.AddToHead(4);
            testList.AddToHead(5);
            testList.AddToHead(6);

            Console.WriteLine("This is what inside the Linked List: \n{0}", testList.DisplayItems());
            Console.ReadKey();
            Console.WriteLine(randomNumb);
            Console.ReadKey();
            Console.WriteLine("The number, {0}, is in the linked list. That is {1}!", randomNumb, testList.ItemIsPresent(randomNumb));
            Console.ReadKey();


            testListGen.AddToHead(1);
            testListGen.AddToHead(2);
            testListGen.AddToHead(3);
            testListGen.AddToHead(54);
            testListGen.AddToHead(4);
            testListGen.AddToHead(5);
            testListGen.AddToHead(6);

            Console.WriteLine("Part 1. This is what inside the generic Linked List: \n{0}", testListGen.DisplayList());
            Console.ReadKey();

            testListGen.RemoveItem(54);

            Console.WriteLine("Part 2. This is what inside the generic Linked List: \n{0}", testListGen.DisplayList());
            Console.ReadKey();

        }

    }
}
