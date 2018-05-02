using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    // Class of the list.
    class CircularList
    {
        // The head of the list.
        public Point Head { get; set; }

        // The tail of the list.
        public Point Tail { get; set; }

        // Constructor without parameters.
        public CircularList()
        {
            Head = null;
            Tail = null;
        }

        // Method to create a circular list of N elements.
        public void CreateCircularList(int N)
        {
            // Creating the head of the list.
            Point head = new Point(N);

            // Creating the tail of the list.
            Point tail = new Point(1);

            // Connecting the head with the tail.
            head.Next = tail;
            tail.Next = head;

            Add(N - 1, head, tail);

            this.Head = tail.Next;
        }

        // Method to add elements (is used in creating the list).
        public static void Add(int N, Point head, Point tail)
        {
            // If N = 0 then it's the end of the list.
            if (N == 1)
            {
                return;
            }
            else
            {
                // Creating a temporary element with the N value.
                Point buf = new Point(N);

                // Adding between the head and the tail.
                head.Next = buf;
                buf.Next = tail;

                // Continue adding but moving the head to the next element.
                Add(N - 1, buf, tail);
            }
        }

        // Search method.
        public Point SearchElem(int value, Point head, Point tail)
        {
            if (head.Value == value || head == tail)
            {
                if (head.Value == value)
                    return head;
                else
                    return new Point(0);
            }
            else
            {
                Point wanted = SearchElem(value, head.Next, tail);
                return wanted;
            }
        }

        // Method to show the list.
        public void Show()
        {
            Point current = this.Head;
            do
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            } while (current != this.Head);
        }
    }
}
