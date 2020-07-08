using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Data_Structures
{
    class LinkedList
    {
        private class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int count;

        public void addLast(int item)
        {
            var node = new Node(item);

            if (isEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
            count++;
        }

        public void addFirst(int item)
        {
            var node = new Node(item);

            if (isEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
            count++;
        }

        private bool isEmpty()
        {
            return first == null;
        }

        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while(current != null)
            {
                if (current.value == item)
                    return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool contains(int item)
        {
            return indexOf(item) != -1;
        }

        public void removeFirst()
        {
            if (isEmpty())
                throw new System.Exception("List is empty.");
            if(first == last)
            {
                first = last = null;
                count--;
                return;
            }

            var second = first.next;
            first.next = null;
            first = second;
            count--;
        }

        public void removeLast()
        {
            if (isEmpty())
                throw new System.Exception("List is empty.");
            if (first == last)
            {
                first = last = null;
                count--;
                return;
            }
            var previous = getPrevious(last);
            last = previous;
            last.next = null;
            count--;
        }

        private Node getPrevious(Node node)
        {
            var current = first;
            while(current != null)
            {
                if (current.next == node)
                    return current;
                current = current.next;
            }
            return null;
        }

        public int size()
        {
            return count;
        }

        public int[] toArray()
        {
            int[] array = new int[count];

            var current = first;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }
    }
}
