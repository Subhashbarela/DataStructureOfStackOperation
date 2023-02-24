using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackOpration
{
    internal class LinkedListQueue
    {
        Node front = null;
        Node rear= null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if(this.rear == null) {
            this.front =this.rear = node;
            }
            else
            {
               this.rear.next= node;
                this.rear = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);

        }
        internal void Display()
        {
            Node temp =this.front;
            if(temp == null) {
                Console.WriteLine("Queue is empty ");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
        internal void Dequeue()
        {

            if(this.front== null)
            {

                Console.WriteLine("Queue is empty :");
                return;
            }
            while (this.front != null) {
                Node temp = this.front;
                this.front = this.front.next;
                if (this.front == null)
                {
                    this.rear = null;
                }
                Console.WriteLine(" Item deleted is {0} ", temp.data);
            }
        }
    }
}
