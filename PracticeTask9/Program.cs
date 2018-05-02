using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    class Program
    {
        // Task: create a circular list of N elements with values from 1 to N (1 is the tail).
        // Add functions to search and delete elements.
        // Student: Alexey Subbotin. Group: SE-17-1.
        static void Main(string[] args)
        {
            // Getting the N.
            Console.Write("Enter the N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            // Creating the list.
            CircularList circularList = new CircularList();
            circularList.CreateCircularList(N);
            circularList.Show();

            Console.ReadLine();
        }
    }
}
