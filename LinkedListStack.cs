using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackOpration
{
    internal class LinkedListStack
    {
        private Node top;
        public LinkedListStack() {
         this.top = null;
        }

        internal void push(int value)
        {
            Node node=new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack ", value);
        }
        internal void Display()
        {
            Node temp= this.top;
            while(temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
        internal void peek() {
        if(this.top ==null)
            {
                Console.WriteLine("Stack is empty ");
                return;
            }
            else
            {
                Console.WriteLine("{0}  is in the top of the stack ", this.top.data);
            }
        }
        internal void pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty Deletion is not posible ");
            }
            else
            {
                Console.Write("Value  popped is : {0}  ", this.top.data);
                this.top = this.top.next;
            }
        }
         internal void IsEmpty()
        {
            while(this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}
