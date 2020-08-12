using System;
using System.Net.Http.Headers;

namespace QueueCircularLinkedList
{
    class QueueCircularL
    {
        private Node rear;

        public QueueCircularL()
        {
            rear = null;
        }

        public void Size()
        {
            int s = 0;
            Node p = rear.link;
            do
            {
                s++;
                p = p.link;
            } while (p != rear.link);
            Console.WriteLine("Size of the Queue is: " + s);
        }

        public bool isEmpty()
        {
            return (rear == null);
        }

        public void Insert(int x)
        {
            Node temp = new Node(x);
            if (rear == null)
            {
                rear = temp;
                rear.link = rear;
            }
            else
            {
                temp.link = rear.link;
                rear.link = temp;
                rear = temp;
            }
        }

        public int Delete()
        {
            Node temp;
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            temp = rear.link;
            rear.link = temp.link;
            return temp.info;
        }

        public int Peek()
        {
            Node temp;
            if(isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            temp = rear.link;
            return temp.info;
        }

        public void Display()
        {
            Node p = rear.link;
            if (isEmpty())
                Console.WriteLine("Queue is Empty");
            Console.WriteLine("Queue is:");
            do
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            } while (p != rear.link);
            Console.WriteLine("");
        }
    }
}
