﻿using CSharpNotes.Classes;
using System;
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

            List<int> nums = new List<int>() { 3, 28, 7, 14, 10 };

            // query expression
            IEnumerable<int> numQuery = from num in nums
                                        where num > 7
                                        orderby num ascending
                                        select num;

            // query not executed until iteration
            Console.WriteLine(String.Join(',', numQuery));

            nums.Add(13);
            // can query execute more than once
            Console.WriteLine(String.Join(',', numQuery));


            List<Car> cars = new List<Car>()
            {
                new Car() { Make = "Honda", Model = "Accord", Year=2012 },
                new Car() { Make = "Honda", Model = "Civic", Year=2010 },
                new Car() { Make = "Honda", Model = "Civic", Year=2008 },
                new Car() { Make = "Nissan", Model = "Maxima", Year=2005 }
            };
            // Anonymous type
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/anonymous-types
            var carQuery = from car in cars
                           where car.Model == "Civic"
                           select new { car.Year };
            foreach (var car in carQuery)
            {
                Console.WriteLine("Civic year: {0}", car.Year);
            }



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

            // int firstDivisibleBySeven = nums.Where(n => n % 7 == 0).FirstOrDefault();
            int firstDivisibleBySeven = nums.FirstOrDefault(n => n % 7 == 0);
            Console.WriteLine($"First element that's divisible by 7: {firstDivisibleBySeven}");

            foreach (var car in cars.OrderBy(p => p.Year))
            {
                Console.WriteLine("{0} {1} {2}", car.Make, car.Model, car.Year);
            }


            // all
            Console.WriteLine("All nums > 0: {0}", nums.All(n => n > 0));
            Console.WriteLine("All nums even: {0}", nums.All(n => n % 2 == 0));

            // any
            Console.WriteLine("Any nums < 0: {0}", nums.Any(n => n < 0));
            Console.WriteLine("Any nums even: {0}", nums.Any(n => n % 2 == 0));


            // TODO: let clause, group, join, data transformations
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/data-transformations-with-linq

        }
    }
}
