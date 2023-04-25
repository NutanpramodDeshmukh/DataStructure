using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace StackandQueue
{
    public class Stack
    {
        Node top;
        public Stack()
        {
          top = null;
        }
        public void push(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = top;
            top = newnode;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack empty");
            }
            else
            {
                Node temp = top;
                while(temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.Next;

                }
            }
        }
    }
}
