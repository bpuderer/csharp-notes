using CSharpNotes.Classes;
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

            // tip: type sw then hit tab tab (snippet)
            // now with "switch_on" highlighted, type the enum type (replacing it)
            // and hit Enter twice. cases are populated with different enum vals
            Car.CarType ct = Car.CarType.Coupe;
            switch (ct)
            {
                case Car.CarType.Sedan:
                    Console.WriteLine("4 doors");
                    break;
                case Car.CarType.Hatchback:
                    Console.WriteLine("2 or 4 doors plus hatch");
                    break;
                case Car.CarType.Coupe:
                    Console.WriteLine("2 doors");
                    break;
                default:
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
            Console.WriteLine(mightBeNull ?? "mightBeNull is null");
        }
    }
}
