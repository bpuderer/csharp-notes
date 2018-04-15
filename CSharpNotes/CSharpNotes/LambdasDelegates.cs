using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CSharpNotes
{
    public static class LambdasDelegates
    {
        public static void Hiya(string text) => Console.WriteLine("Hiya " + text);

        delegate bool MyDelegate1(int x, int y);
        delegate void MyDelegate2(string text);
        public static void Demo()
        {
            // delegate = type safe function pointer, immutable

            // expression lambda - (input-params) => expression
            MyDelegate1 productIsEven = (x, y) => x * y % 2 == 0;
            Console.WriteLine(productIsEven(3, 4));
            Console.WriteLine(productIsEven(3, 5));

            // statement lambda - (input-params) => {statement; }
            MyDelegate2 greetings = n => { Console.WriteLine("Hello " + n); };
            greetings("Guido");
            greetings.Invoke("Raymond");

            // multicast delegate
            greetings += new MyDelegate2(Hiya);
            greetings("Alex");

            // multicast with non-void return type
            Func<int> func = delegate { return 1; };
            func += delegate { return 2; };
            foreach (Func<int> run in func.GetInvocationList()) // can't use var?
            {
                Console.WriteLine(run());
            }

            // generic delegate
            Func<int, int, bool> productDivByThree = (x, y) => x * y % 3 == 0;
            Console.WriteLine(productDivByThree(4, 6));
            
        }
    }
}
