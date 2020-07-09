using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new ArrayQueue(5);
            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);
            Console.WriteLine(queue.peek());
        }
    }
}
