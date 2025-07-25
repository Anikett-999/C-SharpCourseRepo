using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
       
        public string ScrapeWebPage(string url,string filepath)
        {
            string reply = GetWebPage(url);
            //writin to file 
            File.WriteAllText(filepath,reply);
            //Showing to End User
            return reply;
        }
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            return reply;
        }

    }
}
