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
            int N = GetN();

            // Creating the list.
            Console.WriteLine("Created list:");
            CircularList circularList = new CircularList();
            circularList.CreateCircularList(N);
            circularList.Show();

            Console.ReadLine();
        }

        // Method to get the N.
        public static int GetN()
        {
            int N;
            bool ok;
            do
            {
                Console.Write("Enter the N: ");
                ok = Int32.TryParse(Console.ReadLine(), out N);
                if (!ok || N < 2)
                    Console.WriteLine("Input error! N shoud be a natural number greater than 1");
            } while (!ok || N < 2);

            return N;
        }
    }
}
