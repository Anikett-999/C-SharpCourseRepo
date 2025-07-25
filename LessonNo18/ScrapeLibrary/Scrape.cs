using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url, string filepath)
        {
            string reply = GetWebPage(url);
            //writin to file 
            File.WriteAllText(filepath, reply);
            //Showing to End User
            return reply;
        }
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            reply += "THAT'S ALL FOLKS !";
            return reply;
        }
    }
}
