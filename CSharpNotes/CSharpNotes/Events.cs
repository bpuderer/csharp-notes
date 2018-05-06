using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace CSharpNotes
{
    public static class Events
    {
        public static void Demo()
        {
            Console.WriteLine("Hit Enter to stop Timer");
            Timer myTimer = new Timer(2000);
            // += then hit Tab to insert MyTimer_Elapsed method stub
            // register MyTimer_Elapsed with Elapsed event
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;
            myTimer.Start();
            Console.ReadLine();
            myTimer.Stop();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("My_Timer_Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("MyTimer_Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
