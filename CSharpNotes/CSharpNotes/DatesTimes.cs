using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    public static class DatesTimes
    {
        public static void Demo()
        {
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(String.Format("Today: {0}", dt1.ToShortDateString()));
            Console.WriteLine(String.Format("Tomorrow: {0}", dt1.AddDays(1).ToShortDateString()));
            Console.WriteLine(String.Format("Yesterday: {0}", dt1.AddDays(-1).ToShortDateString()));

            DateTime dt2 = new DateTime(2018, 4, 28);
            Console.WriteLine(dt2.ToShortDateString());

            // from string
            DateTime dt3 = DateTime.Parse("4/30/18");
            Console.WriteLine(String.Format("From string: {0}", dt3.ToShortDateString()));

            TimeSpan ts1 = dt3.Subtract(dt2);
            // Days = component of TimeSpan, TotalDays = whole and fractional days
            Console.WriteLine(String.Format("{0} - {1} = {2} days", dt3.ToShortDateString(), dt2.ToShortDateString(), ts1.TotalDays));

        }
    }
}
