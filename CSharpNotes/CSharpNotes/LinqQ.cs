﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpNotes
{
    public static class LinqQ
    {
        public static void Demo()
        {
            // "use query syntax whenever possible and method syntax whenever necessary"
            // where = filter
            // select = projection (when something other than a copy of the source element is produced)

            // query expression
            List<int> nums = new List<int>() { 3, 28, 7, 14, 10 };
            IEnumerable<int> numQuery = from num in nums where num > 7 orderby num ascending select num;
            // query not executed until iteration
            Console.WriteLine(String.Join(',', numQuery));
            nums.Add(13);
            // can query execute more than once
            Console.WriteLine(String.Join(',', numQuery));

            // method
            var numQuery2 = nums.Where(n => n > 7);
            Console.WriteLine(String.Join(',', numQuery2));

            // queries that perform aggregation execute immediately
            // Count, Max, Average, First
            Console.WriteLine(numQuery2.Count());

            // ToList, ToArray also force execution
            var numQuery3 = nums.Where(n => n > 7).ToList();
            Console.WriteLine("second value in result: " + numQuery3[1]);

            // projection
            var numQuery4 = nums.Select(n => n % 2 == 0);
            Console.WriteLine("Element is even: " + String.Join(',', numQuery4));

            int firstDivisibleBySeven = nums.Where(n => n % 7 == 0).FirstOrDefault();
            Console.WriteLine($"First element that's divisible by 7: {firstDivisibleBySeven}");

            // TODO: let clause, group, join, data transformations
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/data-transformations-with-linq

        }
    }
}
