using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to LinkedList");

            {
                //LinkedList<int> list = new LinkedList<int>();
                //list.AddLast(56);
                //list.AddLast(30);
                //list.AddLast(70);


                CustomLinkedList customLinkedList = new CustomLinkedList();
                customLinkedList.InsertLast(56);
                customLinkedList.InsertLast(30);
                customLinkedList.InsertLast(70);
                Console.WriteLine(customLinkedList.Find(30));
                Console.ReadLine();
            }
        }
    }
}
