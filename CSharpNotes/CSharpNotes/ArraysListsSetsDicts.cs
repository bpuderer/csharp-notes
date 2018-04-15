using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpNotes
{
    public static class ArraysListsSetsDicts
    {
        public static void Demo()
        {
            // Arrays
            int[] intArray1 = new int[4];
            int[] intArray2 = { 9000, 1000, 1337 };

            intArray1[0] = 3;
            intArray1[1] = 7;
            intArray1[2] = 3;
            intArray1[3] = 8;
            Console.WriteLine(string.Join(",", intArray1));

            foreach (int element in intArray2)
            {
                Console.WriteLine(element);
            }


            // Lists
            string[] strArray = { "five", "six" };
            List<string> strList = new List<string>() {"two", "three", "four"};

            strList.AddRange(strArray);
            strList.Add("seven");

            Console.WriteLine(string.Join(",", strList));
            Console.WriteLine("Is strList empty? " + !strList.Any());


            // Set. also SortedSet
            HashSet<int> intHashSet = new HashSet<int>();
            intHashSet.Add(4);
            intHashSet.Add(9);
            intHashSet.Add(6);
            intHashSet.Add(7);
            intHashSet.Add(4);
            intHashSet.UnionWith(intArray1);
            Console.WriteLine(string.Join(",", intHashSet));
            intHashSet.RemoveWhere(s => s % 2 == 0);
            Console.WriteLine("Even numbers removed: " + string.Join(",", intHashSet));

            // Dictionary. also SortedDictionary
            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            phonebook.Add("Guido", 1235555678);
            phonebook["Raymond"] = 3215559876;  // indexer
            // KeyValuePair
            foreach(var kvp in phonebook)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // phonebook["Alex"] = 4565555555;
            // TryGetValue faster than catching KeyNotFoundException. almost O(1)
            if (phonebook.TryGetValue("Alex", out long val)) {
                Console.WriteLine($"Alex: {val}");
            }
            else
            {
                Console.WriteLine("Alex not found in phonebook");
            }

        }
    }
}
