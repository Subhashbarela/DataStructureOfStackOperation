using System;
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
            LinkedListStack stack = new LinkedListStack();
            stack.push(56);
            stack.push(30);
            stack.push(70);
           
            Console.WriteLine("...........................\n");
            stack.Display();
            Console.WriteLine("\n..........................");
           
            stack.pop();
            Console.WriteLine("\nRemaining value after pop : ");
            stack.Display();
           
            Console.WriteLine("\n..........................");
            stack.peek();

            Console.WriteLine("\n..........................");
            stack.IsEmpty();
            Console.Read();
        }
    }
}
