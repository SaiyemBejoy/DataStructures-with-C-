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
            var list = new LinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addFirst(5);
            Console.WriteLine(list.indexOf(10));
            Console.WriteLine(list.contains(20));
            var array = list.toArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
