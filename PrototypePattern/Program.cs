using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var scrapper = new WebPageScrapper("http://www.google.com");
            scrapper.PrintPAgeData();
            //This is not doable is the client is in separate assembly 
            //var complicatedObject = new ComplicatedUnstableObject()

            //Instead what we cabn do is just get the object using the clone.

            var scrapper2 = scrapper.Clone() as WebPageScrapper;
            scrapper.PrintPAgeData();
            Console.ReadKey();
        }
    }
}
