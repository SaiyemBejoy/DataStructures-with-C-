using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            Console.WriteLine(numbers.indexOf(20));
            numbers.print();
        }
    }
}
