﻿using System;
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

            Random rnd = new Random();
            Console.WriteLine(String.Format("Random num: {0}", rnd.Next()));
            Console.WriteLine(String.Format("Random num [3..28]: {0}", rnd.Next(3, 29)));

            Console.WriteLine("Even numbers [3..28]:");
            // Enumerable.Range(3, 26).Where(n => n % 2 == 0).ToList().ForEach(Console.WriteLine);
            foreach (var num in Enumerable.Range(3, 26).Where(n => n % 2 == 0))
            {
                Console.WriteLine(num);
            }
            
        }
    }
}