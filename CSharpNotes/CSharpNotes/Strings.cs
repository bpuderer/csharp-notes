using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    public static class Strings
    {
        public static void Demo()
        {
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/best-practices-strings

            // @ verbatim string literal
            Console.WriteLine(@"Here is a backslash: \");

            Console.WriteLine("Escape char: \\");

            int i1 = 1;
            int i2 = 2;
            // composite formatting {index[,alignment][:formatString]}
            Console.WriteLine("First: {0} Second: {1} First (again): {0}", i1, i2);

            // string interpolation {<interpolatedExpression>[,<alignment>][:<formatString>]}
            Console.WriteLine($"First: {i1} Second: {i2}");

            int[] intArray = { 9000, 1000, 1337 };
            Console.WriteLine(String.Join(",", intArray));

            // Contains. also StartsWith, EndsWith
            string s = "how much more black could this be";
            Console.WriteLine(s.Contains("black"));
            Console.WriteLine(s.Contains("Black"));
            Console.WriteLine(s.IndexOf("Black", StringComparison.OrdinalIgnoreCase) > 0);

            // replace char. strings are immutable
            char[] sAsChars = s.ToCharArray();
            sAsChars[0] = 'H';
            string sUpdated = new string(sAsChars);
            Console.WriteLine(sUpdated);

            // substr
            Console.WriteLine(s.Substring(14, 5));

            // replace
            Console.WriteLine(s.Replace("how", "HOW"));

            Console.WriteLine("s is unchanged: " + s);

            // trim
            string sWithWhitespace = "     Well, it's one louder, isn't it? \t \r\n";
            Console.WriteLine(sWithWhitespace);
            Console.WriteLine(sWithWhitespace.Trim());

            // strings are immutable. StringBuilder for efficiency
            StringBuilder sb = new StringBuilder();
            for (int i=0; i < 5; i++)
            {
                sb.Append(i);
            }
            sb[3] = '9';
            Console.WriteLine(sb);

            // comparison
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/best-practices-strings
            string s1 = "spam";
            string s2 = "Spam";
            Console.WriteLine(s1.Equals(s2, StringComparison.OrdinalIgnoreCase));

            // split
            string[] words = "spam and eggs".Split(' ');
            Console.WriteLine(string.Join(',', words));
        }
    }
}
