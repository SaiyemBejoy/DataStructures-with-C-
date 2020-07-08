using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class StackViaArray
    {
        private int[] items = new int[5];
        private int count;

        public void push(int item)
        {
            if (count == items.Length)
                throw new System.StackOverflowException();

            items[count++] = item;
        }
        public int pop()
        {
            if (empty())
                throw new System.Exception("Stack is empty");

            return items[--count];
        }

        public bool empty()
        {
            return count == 0;
        }

        public int peek()
        {
            if (empty())
                throw new System.Exception("Stack is Empty");
            return items[count - 1];
        }
    }
}
