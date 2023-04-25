using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class DS
    {
        Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else {
                Node Temp = head;
                while (Temp.Next != null)
                {
                    Temp = Temp.Next;
                }
                Temp.Next = node;
            }
            Console.WriteLine("inserted into list{0}", node.data);
        }
        public void AddReverseData(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }else
            {
                Node temp = this.head;
                head = newNode;
                head.Next = temp;
            }
        }
        public void PopLast()
        {
            Node tempnode = head;
            Node lastnode = tempnode.Next;
            if (head.Next != null)
            {
                tempnode = tempnode.Next;
                tempnode.Next = null;
                lastnode = null;
            }

        }
        public void Display()
        {
            if(head==null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list is empty");
                Console.ResetColor();
            }else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(":Linked List Contain");
                Console.ResetColor();
                Node tempnode = head;
                while (tempnode != null)
                {
                    Console.Write(tempnode.data + "");
                    tempnode = tempnode.Next;

                }
                Console.WriteLine("\n");
            }
        }
    }
}
