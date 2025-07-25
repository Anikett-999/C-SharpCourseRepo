using MyCodeLibrary;
namespace MyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUrl = "";
            string path = " ";
            string code = " ";
            Console.WriteLine("Enter a Webpage Url:");
            inputUrl = Console.ReadLine();
            // Console.WriteLine("Give a Path To store the Weppage");
            path = @"E:\\C#\\MyClient\new.txt";

            Scrape scrape = new Scrape();
            code = scrape.ScrapeWebPage(inputUrl,path);
            Console.WriteLine(code);
            Console.WriteLine("YourCode is Stored Here :" + path);
            Console.ReadLine();
        }
    }
}
