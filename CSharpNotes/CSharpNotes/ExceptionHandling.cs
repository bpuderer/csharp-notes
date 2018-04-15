using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    public static class ExceptionHandling
    {
        public static void Demo()
        {
            // try-catch, try-finally, try-catch-finally

            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            // phonebook.Add("Raymond", 1235555678);

            try
            {
                Console.WriteLine(phonebook["Raymond"]);
            }
            catch (KeyNotFoundException) // exception filter
            {
                Console.WriteLine("No entry for Raymond");
                // throw; // re-throw
            }
            finally
            {
                Console.WriteLine("Code in finally always executed");
            }
            

            try
            {
                throw new ArgumentOutOfRangeException("<problem parameter>");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught ArgumentOutOfRangeException:\n{ex}");
            }

        }
    }
}
