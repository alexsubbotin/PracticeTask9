using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    // Class of the list elements.
    class Point
    {
        // Value.
        public int Value { get; set; }

        // The next element.
        public Point Next { get; set; }

        // Constructor.
        public Point(int Value)
        {
            this.Value = Value;
            this.Next = null;
        }
    }
}
