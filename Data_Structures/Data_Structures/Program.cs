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
            var stack = new StackViaArray();
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.push(40);
            stack.push(50);
            var top = stack.peek();
            Console.WriteLine("Peek: "+top);
            while (!stack.empty())
            {
                Console.WriteLine(stack.pop());
            }
        }
    }
}
