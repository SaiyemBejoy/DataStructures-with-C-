using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class Array
    {
        private int[] items;
        private int count;
        public Array(int length)
        {
            items = new int[length];
        }

        public void print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }

        public void insert(int item)
        {
            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                items = newItems;
            }

            items[count++] = item;
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
                throw new System.ArgumentException("Index is undefined");

            for (int i = index; i < count; i++)
                items[i] = items[i + 1];

            count--;
        }

        public int indexOf(int item)
        {
            for (int i = 0; i < count; i++)
                if (items[i] == item)
                    return i;
            return -1;
        }
    }
}
