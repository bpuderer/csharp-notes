using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    public static class ScrapeClient
    {
        public static void Demo()
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("https://en.wikipedia.org/wiki/John_Cleese");
            Console.WriteLine(value);
        }
    }
}