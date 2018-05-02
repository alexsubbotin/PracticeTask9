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
            this.Tail = tail;
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
        public Point SearchElem(int value, Point curr, Point tail)
        {
            // If found or it's the end of the list.
            if (curr.Value == value || (curr.Value == tail.Value && curr.Next == tail.Next))
            {
                // If found then return it else create an empty object.
                if (curr.Value == value)
                    return curr;
                else
                    return new Point(0);
            }
            else
            {
                // Check the next.
                Point wanted = SearchElem(value, curr.Next, tail);
                return wanted;
            }
        }

        // Delete method.
        public Point DeleteElem(int value, Point prev, Point curr, Point tail)
        {
            // If found or it's the end of the list.
            if (curr.Value == value || (curr.Value == tail.Value && curr.Next == tail.Next))
            {
                // If found then delete it.
                if (curr.Value == value)
                    prev.Next = curr.Next;

                return tail;
            }
            else
            {
                // Checking the next.
                Point deleted = DeleteElem(value, prev.Next, curr.Next, tail);
                return deleted;
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
