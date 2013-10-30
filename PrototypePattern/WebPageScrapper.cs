using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mime;

namespace PrototypePattern
{
    public class WebPageScrapper : ICloneable
    {
        private string title;
        private int headerTagCount;
        private string firstHeaderTagContents;

        public WebPageScrapper(string url)
        {
            var client = new WebClient();
            Scrape(client.DownloadString(url));
        }

        private void Scrape(string page)
        {
            title = "Fake title";
            headerTagCount = 3;
            firstHeaderTagContents = "Fake HEader text";
        }

        public void PrintPAgeData()
        {
            Console.WriteLine("Title:{0}, HeaderCount: {1}, FirstHeader: {2}", title, headerTagCount, firstHeaderTagContents);
        }

        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion

        public static bool IsValidImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    var imageCreated = Image.FromStream(ms);
                    
                }
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
    }
}