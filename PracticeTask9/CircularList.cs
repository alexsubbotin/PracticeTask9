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
        Point Head { get; set; }

        // The tail of the list.
        Point Tail { get; set; }

        // Constructor without parameters.
        public CircularList()
        {
            Head = null;
            Tail = null;
        }

        // Method to create a circular list of N elements.
        public static Point CreateCircularList(int N, Point current)
        {
            // Creating the head of the list.
            Point head = new Point(N);

            // Creating the tail of the list.
            Point tail = new Point(1);

            // Connecting the head with the tail.
            head.Next = tail;
            tail.Next = head;

            Add(N - 1, head, tail);

            // Returning the head.
            return tail.Next;
        }

        // Method to add elements (is used in creating the list).
        public static void Add(int N, Point head, Point tail)
        {
            // If N = 0 then it's the end of the list.
            if (N == 0)
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
    }
}
