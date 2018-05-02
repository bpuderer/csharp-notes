using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    public static class Methods
    {
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static void Params(int x, int y=7, params int[] otherParams)
        {
            Console.WriteLine(String.Format("x: {0} y: {1}", x, y));
            // params = *args, variable args
            Console.Write("otherParams: ");
            Console.WriteLine(String.Join(",", otherParams));
        }

        public static void Demo()
        {
            string testStr = "python";
            Console.WriteLine(String.Format("{0} reversed is {1}", testStr, Reverse(testStr)));
            Params(1, 2);
            Params(1);
            Params(y: 3, x: 28);
            Params(1, 2, 3, 4, 5, 6);
        }
    }
}
