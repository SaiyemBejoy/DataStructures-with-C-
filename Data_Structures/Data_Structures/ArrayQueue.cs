using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class ArrayQueue
    {
        private int[] items;
        private int rear;
        private int front;
        private int count;

        public ArrayQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void enqueue(int item)
        {
            if (count == items.Length)
                throw new System.Exception("Queue is full");

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }

        public int dequeue()
        {
            if (empty())
                throw new System.Exception("Queue is empty");

            var item = items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        public bool empty()
        {
            return count == 0;
        }

        public int peek()
        {
            return items[front];
        }
    }
}
