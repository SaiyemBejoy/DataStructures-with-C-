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
            HashMap table = new HashMap();
            table.put(6, "A");
            table.put(8, "B");
            table.put(11, "C");
            table.remove(8);
            Console.WriteLine(table.get(8));
        }
    }
}
