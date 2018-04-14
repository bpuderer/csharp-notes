using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    public static class Looping
    {
        public static void Demo()
        {
            for (int i=0; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---");

            int[] myArray = new int[] { 1, 2, 3, 4 };
            // implements the System.Collections.IEnumerable or
            // System.Collections.Generic.IEnumerable<T> interface
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---");

            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 4);

            Console.WriteLine("---");

            counter = 0;
            while (counter < 4)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
