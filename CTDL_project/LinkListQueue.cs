using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace CTDL_project
{
    //this class will depict Linked List implementation of Queue
    internal class LinkListQueue
    {
        public Node front;
        public Node rear;

        public LinkListQueue()
        {
            this.front = this.rear = null;
        }

        // Method to add an element to the queue.
        internal void Enqueue(Control item)
        {
            Node newNode = new Node(item);

            // If queue is empty, then new node is front and rear both
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear
                this.rear.next = newNode;
                this.rear = newNode;
            }
        }

        // Method to remove an element from queue.
        internal void Dequeue()
        {
            // If queue is empty, return NULL.
            if (this.front == null)
            {
                return;
            }

            // Store previous front and move front one node ahead
            Node temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL
            if (this.front == null)
            {
                this.rear = null;
            }
        }

        // Method to clear queue
        internal void ClearQueue()
        {
            if (this.front == null)
            {
                return;
            }

            Node temp = this.front;

            while (temp != null)
            {
                Dequeue();
                temp = temp.next;
            }
        }

        // Method to count lenght of Queue
        internal int lenghtQueue()
        {
            int i = 0;
            Node temp = this.front;
            while (temp != null)
            {
                i += 1;
                temp = temp.next;
            }
            return i;
        }

        // Method to print Queue elements
        internal void PrintQueue()
        {
            if (this.front == null)
            {
                return;
            }

            Node temp = this.front;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
