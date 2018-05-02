using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpNotes
{
    public static class Misc
    {
        public static void Demo()
        {
            // ^E^F format selection, ^E^D format doc

            // Tools > NuGet Package Manager > Manage NuGet Packages for Solution...

            Random rnd = new Random();
            Console.WriteLine(String.Format("Random num: {0}", rnd.Next()));
            Console.WriteLine(String.Format("Random num [3..28]: {0}", rnd.Next(3, 29)));

            Console.WriteLine("Even numbers [3..28]:");
            // Enumerable.Range(3, 26).Where(n => n % 2 == 0).ToList().ForEach(Console.WriteLine);
            foreach (var num in Enumerable.Range(3, 26).Where(n => n % 2 == 0))
            {
                Console.WriteLine(num);
            }

            // nullable type. can use any value type
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine(String.Format("x: {0}, y: {1}", x, y));

            const int secondsInDay = 86400;

        }
    }
}
