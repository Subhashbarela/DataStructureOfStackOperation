﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackOpration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("...........................\n");
            queue.Display();
            Console.WriteLine("\n...........................\n");
            queue.Dequeue();
            Console.WriteLine("\n...........................\n");
            Console.WriteLine("After Dequeue operation...... \n");
            queue.Display();
            Console.Read();


        }
    }
}
