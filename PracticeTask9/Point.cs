using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    // Class of the list elements.
    class Point<T>
    {
        // Value.
        public T Value { get; set; }

        // The next element.
        public Point<T> Next { get; set; }

        // Constructor.
        public Point(T Value)
        {
            this.Value = Value;
            this.Next = null;
        }
    }
}
