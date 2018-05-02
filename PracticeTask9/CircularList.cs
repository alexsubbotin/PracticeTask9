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

            return head;
        }

        public static void Add(int N, Point head, Point tail)
        {
            if (N == 0)
            {
                return;
            }
            else
            {
                Point buf = new Point(N);
                head.Next = buf;
                buf.Next = tail;
                Add(N - 1, head, tail);
            }
        }
    }
}
