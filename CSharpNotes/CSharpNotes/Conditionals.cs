using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    public static class Conditionals
    {
        public static void Demo()
        {
            int i = 2;
            if (i > 0)
            {
                Console.WriteLine("positive");
            }
            else if (i < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }

            switch (i)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("2 or 3");
                    break;
                default:
                    Console.WriteLine("not 1, 2 or 3");
                    break;
            }

            // ternary ?:
            string outcome;
            outcome = (true) ? "first" : "second";
            Console.WriteLine(outcome);

            // null conditional  ?. ?[]
            string mightBeNull = null;
            // string mightBeNull = "notnull";
            Console.WriteLine(mightBeNull?.Length);

            // null coalescing ??
            Console.WriteLine(mightBeNull ?? "null val");
        }
    }
}
